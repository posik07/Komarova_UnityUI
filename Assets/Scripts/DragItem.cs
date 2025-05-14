using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Canvas dragCanvas;
    public bool isOriginal = true; // Если true — создаём клон, если false — двигаем сам объект

    private GameObject dragClone;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private Vector3 originalPosition;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        if (canvasGroup == null)
        {
            canvasGroup = gameObject.AddComponent<CanvasGroup>();
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (isOriginal)
        {
            // Копируем элемент
            dragClone = Instantiate(gameObject, dragCanvas.transform);
            dragClone.GetComponent<DragItem>().isOriginal = false;
            dragClone.GetComponent<CanvasGroup>().blocksRaycasts = false;
            dragClone.transform.position = eventData.position;
        }
        else
        {
            // Просто двигаем саму одежду на персонаже
            originalPosition = rectTransform.position;
            canvasGroup.blocksRaycasts = false;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (isOriginal)
        {
            if (dragClone != null)
                dragClone.transform.position = eventData.position;
        }
        else
        {
            rectTransform.position = eventData.position;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (isOriginal)
        {
            Destroy(dragClone); // Клон исчезает, если никуда не брошен
        }
        else
        {
            canvasGroup.blocksRaycasts = true;
        }
    }
}
