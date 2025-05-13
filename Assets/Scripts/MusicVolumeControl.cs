// ������ ��� ���������� ����������
using UnityEngine;
using UnityEngine.UI;

public class MusicVolumeControl : MonoBehaviour
{
    public AudioSource musicSource;
    public Slider volumeSlider;

    void Start()
    {
        volumeSlider.onValueChanged.AddListener(SetVolume);
        volumeSlider.value = musicSource.volume; // ������������� � ������� ����������
    }

    public void SetVolume(float value)
    {
        musicSource.volume = value;
    }
}
