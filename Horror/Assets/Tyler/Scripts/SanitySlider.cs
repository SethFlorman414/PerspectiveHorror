using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SanitySlider : MonoBehaviour
{
    Slider slider;

    int sanity = 250;
    int maxSanity = 250;

    public Image Fill;

    Color MaxColor = new Color32 (75, 171, 72, 255);
    Color MinColor = new Color32 (243, 22, 22, 255);
	
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
        Fill.color = Color.Lerp(MinColor, MaxColor, (float)sanity / maxSanity);
        
        // makes slider flash
        //Fill.color = Color.Lerp(MaxColor, MinColor, Mathf.PingPong(Time.time, 1));

        //sanity--;
    }
}
