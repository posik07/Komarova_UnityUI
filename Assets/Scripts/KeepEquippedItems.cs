using UnityEngine;

public class KeepEquippedItems : MonoBehaviour
{
    // Массив объектов одежды на персонаже
    public GameObject[] equippedItems;

    // Этот метод вызывается, когда переключается категория одежды
    public void OnCategoryChange()
    {
        foreach (var item in equippedItems)
        {
            item.SetActive(true); // Убедимся, что вещи остаются видимыми
        }
    }
}
