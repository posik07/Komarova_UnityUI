using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
    public Transform equippedHolder;

    public void OnDrop(PointerEventData eventData)
    {
        GameObject draggedObj = DraggableItem.selectedItem;

        if (draggedObj != null)
        {
            // Перемещаем объект внутрь equippedHolder
            draggedObj.transform.SetParent(equippedHolder);

            // Обнуляем локальную позицию (если надо)
            draggedObj.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
        }
    }
}
