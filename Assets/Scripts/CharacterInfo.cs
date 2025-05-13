using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterInfo : MonoBehaviour
{
    public InputField nameInput;
    public InputField yearInput;
    public Text resultText;

    public void ShowCharacterInfo()
    {
        string charName = nameInput.text;

        // Проверка: имя не должно быть числом
        if (int.TryParse(charName, out _))
        {
            resultText.text = "Vārda laukā nevar ievadīt tikai ciparus!";
            return;
        }

        // Проверка: введён ли год и является ли он числом
        if (int.TryParse(yearInput.text, out int birthYear))
        {
            int currentYear = DateTime.Now.Year;
            int age = currentYear - birthYear;

            if (age >= 0 && age < 150) // Простейшая проверка
            {
                resultText.text = $"Personāžs {charName} ir {age} gadus vecs!";
            }
            else
            {
                resultText.text = "Ievadiet pareizu dzimšanas gadu";
            }
        }
        else
        {
            resultText.text = "Dzimšanas gadam ir jābūt skaitlim";
        }
    }
}
