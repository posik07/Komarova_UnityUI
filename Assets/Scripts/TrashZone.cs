using UnityEngine;
using UnityEngine.EventSystems;

public class TrashZone : MonoBehaviour, IDropHandler
{
    private AudioSource audioSource;  // Ссылка на AudioSource для воспроизведения звука
    public AudioClip dropSound;  // Звуковой эффект для перетаскивания и отпускания

    void Start()
    {
        // Получаем компонент AudioSource с объекта
        audioSource = GetComponent<AudioSource>();
    }

    // Когда предмет попадает в мусорку
    public void OnDrop(PointerEventData eventData)
    {
        var dragged = eventData.pointerDrag;  // Получаем перетаскиваемый объект

        if (dragged != null)
        {
            var dragItem = dragged.GetComponent<DragItem>();  // Получаем компонент DragItem

            if (dragItem != null && !dragItem.isOriginal) // Если это одежда на персонаже
            {
                // Удаляем одежду, если она на персонаже (не оригинальная)
                Destroy(dragged);  // Удаляем объект из сцены

                // Воспроизводим звук
                PlaySound();
            }
        }
    }

    // Метод для воспроизведения звука
    private void PlaySound()
    {
        if (audioSource != null && dropSound != null)
        {
            audioSource.PlayOneShot(dropSound);  // Воспроизводим звук
        }
    }
}
