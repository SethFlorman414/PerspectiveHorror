using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story1 : MonoBehaviour {

    // Use this for initialization

    public GameObject canvas;

    public float timer;

    public GameObject text;
    public GameObject text2;
    public GameObject text3;

    public bool forTImer;
    private bool hasFinished = false;


    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(forTImer && !hasFinished)
        {

            timer += Time.deltaTime;

        }
        

        if(timer >= 10.0f)
        {
            text.SetActive(false);
            text2.SetActive(true);

        }

        if(timer >= 15.0f)
        {
            text2.SetActive(false);
            text3.SetActive(true);

        }

        if(timer >= 20.0f)
        {
            text3.SetActive(false);
            canvas.SetActive(false);
            forTImer = false;
            GetComponent<Collider>().enabled = false;

        }
		
	}

    public void OnTriggerEnter(Collider collide)
    {
        
        if(collide.gameObject.tag == "Player")
        {

            canvas.SetActive(true);
            text.SetActive(true);
            forTImer = true;

        }



    }

}
