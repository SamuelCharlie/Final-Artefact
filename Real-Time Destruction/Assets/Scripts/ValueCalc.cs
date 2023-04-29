using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValueCalc : MonoBehaviour
{
    public Slider massSlider;
    public float sliderMassValue = 0;
    private TMPro.TMP_Text _textSliderValue;

    private void Start()
    {
        _textSliderValue = GetComponent<TMPro.TMP_Text>();
        sliderMassValue = massSlider.value;
        ShowSliderValueMass();
    }

    public void ShowSliderValueMass()
    {
        string sliderMessage = "Mass of Fragments: " + massSlider.value;
        sliderMassValue = massSlider.value;
        _textSliderValue.text = sliderMessage;
    }
}
