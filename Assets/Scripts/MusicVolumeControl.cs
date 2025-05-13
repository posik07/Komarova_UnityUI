// Скрипт для управления громкостью
using UnityEngine;
using UnityEngine.UI;

public class MusicVolumeControl : MonoBehaviour
{
    public AudioSource musicSource;
    public Slider volumeSlider;

    void Start()
    {
        volumeSlider.onValueChanged.AddListener(SetVolume);
        volumeSlider.value = musicSource.volume; // Инициализация с текущей громкостью
    }

    public void SetVolume(float value)
    {
        musicSource.volume = value;
    }
}
