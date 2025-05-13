using UnityEngine;

public class KeepEquippedItems : MonoBehaviour
{
    // ������ �������� ������ �� ���������
    public GameObject[] equippedItems;

    // ���� ����� ����������, ����� ������������� ��������� ������
    public void OnCategoryChange()
    {
        foreach (var item in equippedItems)
        {
            item.SetActive(true); // ��������, ��� ���� �������� ��������
        }
    }
}
