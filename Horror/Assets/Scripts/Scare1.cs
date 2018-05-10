using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Scare1 : MonoBehaviour {

    // Use this for initialization

    public GameObject character1;
    public GameObject scareLight;

    public Animator scare;

    public float timer;
    
    public bool forTimer;
    public bool forSound;

    public AudioSource sound;

    public AudioClip newSound;

    public FirstPersonController script;


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (forTimer)
        {
            timer += Time.deltaTime;

        }
        
        
        if(timer >= 2.0f && !forSound)
        {
            scareLight.SetActive(false);
            character1.SetActive(true);
            scare.SetBool("Scare", true);
            sound.PlayOneShot(newSound);
            forSound = true;

        }

        if(timer >= 5.0f)
        {
            scareLight.SetActive(true);
            character1.SetActive(false);
            scare.SetBool("Scare", false);
            script.GetComponent<FirstPersonController>().enabled = true;
            forTimer = false;

        }



        
	}


    public void OnTriggerEnter(Collider other)
    {

        

        
        if(other.gameObject.tag == "Scare1")
        {

            script.GetComponent<FirstPersonController>().enabled = false;
           // character1.SetActive(true);
            forTimer = true;

        }


    }

}
