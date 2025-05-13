using UnityEngine;
using UnityEngine.UI;

public class ClothingCategoryManager : MonoBehaviour
{
    [Header("Toggles")]
    public Toggle toggleDresses;
    public Toggle toggleAccessories;
    public Toggle toggleBottom;
    public Toggle toggleShoes;
    public Toggle toggleSocks;
    public Toggle toggleHats;
    public Toggle toggleTop;

    [Header("Clothing Images")]
    public GameObject[] dresses;
    public GameObject[] accessories;
    public GameObject[] bottoms;
    public GameObject[] shoes;
    public GameObject[] socks;
    public GameObject[] hats;
    public GameObject[] tops;

    void Start()
    {
        // Скрываем все одежду при старте
        HideAllClothing();

        // Подключаем события выбора категорий
        toggleDresses.onValueChanged.AddListener((isOn) => { if (isOn) ShowClothing(dresses); });
        toggleAccessories.onValueChanged.AddListener((isOn) => { if (isOn) ShowClothing(accessories); });
        toggleBottom.onValueChanged.AddListener((isOn) => { if (isOn) ShowClothing(bottoms); });
        toggleShoes.onValueChanged.AddListener((isOn) => { if (isOn) ShowClothing(shoes); });
        toggleSocks.onValueChanged.AddListener((isOn) => { if (isOn) ShowClothing(socks); });
        toggleHats.onValueChanged.AddListener((isOn) => { if (isOn) ShowClothing(hats); });
        toggleTop.onValueChanged.AddListener((isOn) => { if (isOn) ShowClothing(tops); });
    }

    // Показываем только нужную категорию
    void ShowClothing(GameObject[] clothingItems)
    {
        // Скрываем все элементы одежды
        HideAllClothing();

        // Показываем элементы для выбранной категории
        foreach (var item in clothingItems)
        {
            item.SetActive(true);
        }
    }

    // Скрываем все элементы одежды
    void HideAllClothing()
    {
        // Скрываем изображения для каждой категории
        foreach (var item in dresses)
            item.SetActive(false);

        foreach (var item in accessories)
            item.SetActive(false);

        foreach (var item in bottoms)
            item.SetActive(false);

        foreach (var item in shoes)
            item.SetActive(false);

        foreach (var item in socks)
            item.SetActive(false);

        foreach (var item in hats)
            item.SetActive(false);

        foreach (var item in tops)
            item.SetActive(false);
    }
}
