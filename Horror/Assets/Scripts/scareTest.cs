using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scareTest : MonoBehaviour {

    public bool scareNow = false;
    public int additive = 1;
    public heartRate HR;
	
	// Update is called once per frame
	void Update () {
		if(scareNow)
        {
           HR.Scare(additive);
            scareNow = false;
        }
	}
}
