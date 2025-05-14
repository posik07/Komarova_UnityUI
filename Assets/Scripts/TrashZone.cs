using UnityEngine;
using UnityEngine.EventSystems;

public class TrashZone : MonoBehaviour, IDropHandler
{
    private AudioSource audioSource;  // ������ �� AudioSource ��� ��������������� �����
    public AudioClip dropSound;  // �������� ������ ��� �������������� � ����������

    void Start()
    {
        // �������� ��������� AudioSource � �������
        audioSource = GetComponent<AudioSource>();
    }

    // ����� ������� �������� � �������
    public void OnDrop(PointerEventData eventData)
    {
        var dragged = eventData.pointerDrag;  // �������� ��������������� ������

        if (dragged != null)
        {
            var dragItem = dragged.GetComponent<DragItem>();  // �������� ��������� DragItem

            if (dragItem != null && !dragItem.isOriginal) // ���� ��� ������ �� ���������
            {
                // ������� ������, ���� ��� �� ��������� (�� ������������)
                Destroy(dragged);  // ������� ������ �� �����

                // ������������� ����
                PlaySound();
            }
        }
    }

    // ����� ��� ��������������� �����
    private void PlaySound()
    {
        if (audioSource != null && dropSound != null)
        {
            audioSource.PlayOneShot(dropSound);  // ������������� ����
        }
    }
}
