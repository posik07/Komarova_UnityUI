using UnityEngine;
using UnityEngine.UI;

public class ClothingResizer : MonoBehaviour
{
    public Slider widthSlider;
    public Slider heightSlider;

    private RectTransform selectedClothing;

    void Start()
    {
        widthSlider.onValueChanged.AddListener(OnWidthChanged);
        heightSlider.onValueChanged.AddListener(OnHeightChanged);
    }

    public void SetSelectedClothing(RectTransform clothing)
    {
        selectedClothing = clothing;

        if (selectedClothing != null)
        {
            widthSlider.value = selectedClothing.localScale.x;
            heightSlider.value = selectedClothing.localScale.y;
        }
    }

    private void OnWidthChanged(float value)
    {
        if (selectedClothing != null)
        {
            selectedClothing.localScale = new Vector3(value, selectedClothing.localScale.y, 1f);
        }
    }

    private void OnHeightChanged(float value)
    {
        if (selectedClothing != null)
        {
            selectedClothing.localScale = new Vector3(selectedClothing.localScale.x, value, 1f);
        }
    }
}
