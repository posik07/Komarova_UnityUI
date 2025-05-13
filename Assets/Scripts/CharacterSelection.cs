using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    public Sprite[] soriteArray;
    public GameObject imageField; //att

    public void Dropdown(int index)
    {
        if (index == 0)
            imageField.GetComponent<Image>().sprite = soriteArray[0];
        else if (index == 1)
            imageField.GetComponent<Image>().sprite = soriteArray[1];
        else if (index == 2)
            imageField.GetComponent<Image>().sprite = soriteArray[2];
    }
}
