using UnityEngine.EventSystems;
using UnityEngine;

public class DropZone : MonoBehaviour, IDropHandler
{
    public Transform characterLayer;

    public void OnDrop(PointerEventData eventData)
    {
        var dragged = eventData.pointerDrag;
        if (dragged != null)
        {
            var original = dragged.GetComponent<DragItem>();
            if (original != null && original.isOriginal)
            {
                // Создать одежду на персонаже
                GameObject clothing = Instantiate(dragged, characterLayer);
                clothing.transform.position = Input.mousePosition;

                var dragItem = clothing.GetComponent<DragItem>();
                dragItem.isOriginal = false; // Это теперь элемент на персонаже
                dragItem.dragCanvas = original.dragCanvas;
            }
        }
    }
}
