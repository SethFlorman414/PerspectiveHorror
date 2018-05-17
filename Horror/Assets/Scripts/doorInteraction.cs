using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorInteraction : MonoBehaviour {

    public string boolName;
    public float secondsUntilDoorCloses;
    bool open;
    float timer;
	// Update is called once per frame
	void Update ()
    {
		if(open)
        {
            timer += Time.deltaTime;
            if(timer >= secondsUntilDoorCloses)
            {
                timer = 0;
                open = false;
                GetComponent<Animator>().SetBool(boolName, false);
            }
        }

	}

    public void interact()
    {
        GetComponent<Animator>().SetBool(boolName, true);
        open = true;
    }
}
