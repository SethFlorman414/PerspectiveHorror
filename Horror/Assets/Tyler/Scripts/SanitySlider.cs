using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SanitySlider : MonoBehaviour
{
    Slider slider;

    int sanity = 250;

    public Image Fill;

    public Color MaxColor = Color.green;
    public Color MinColor = Color.red;
	
    void Start()
    {
        slider = gameObject.GetComponent<Slider>();


        slider.wholeNumbers = true;
        slider.minValue = 0f;
        slider.maxValue = sanity;
        slider.value = sanity;
    }

    void Update ()
    {
        slider.value = sanity;
        Fill.color = Color.Lerp(MaxColor, MinColor, Mathf.PingPong(Time.time, 1));

        sanity--;
    }
}
