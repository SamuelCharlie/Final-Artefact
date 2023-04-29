using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VeloCalc : MonoBehaviour
{
    public Slider veloSlider;
    public float sliderVeloValue = 0;
    private TMPro.TMP_Text _textSliderValue;

    private void Start()
    {
        _textSliderValue = GetComponent<TMPro.TMP_Text>();
        sliderVeloValue = veloSlider.value;
        ShowSliderValueVelo();
    }

    public void ShowSliderValueVelo()
    {
        string sliderMessage = "Velocity of Projectile: " + veloSlider.value;
        sliderVeloValue = veloSlider.value;
        _textSliderValue.text = sliderMessage;
    }
}
