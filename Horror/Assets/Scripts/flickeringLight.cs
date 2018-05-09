using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flickeringLight : MonoBehaviour {

    public Vector2 intensityRange;
    public Vector2 intervalRange;
    private Light l;
    private float i;
    private float t;

    private void Start()
    {
        l = GetComponent<Light>();
        i = intensityRange.x;
    }



    void Update ()
    {
        t += Time.deltaTime;
        if (t >= i)
        {
            t = 0;
            i = Random.Range(intervalRange.x, intervalRange.y);
            float r = Random.Range(intensityRange.x, intensityRange.y);
            l.intensity = r;
        }

	}
}
