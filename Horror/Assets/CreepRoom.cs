using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class CreepRoom : MonoBehaviour {

    // Use this for initialization

    public AudioSource scare;

    public GameObject husk;
    public GameObject light;

    public Animator door;

    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;

    public Texture otherWallTexture;
    public Texture newNewWallTexture;
    public Texture moreWallTexture;

    public FirstPersonController script;

    public float timer;

    public bool forTimer;

    public GameObject canvas;

    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;


    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (forTimer)
        {

            timer += Time.deltaTime;

        }
        
        
        if(timer >= 40.0f)
        {

            scare.Stop();
            light.SetActive(false);
            canvas.SetActive(true);
            text1.SetActive(true);
            script.GetComponent<FirstPersonController>().enabled = false;

        }

        if(timer >= 43.0f)
        {
            text1.SetActive(false);
            text2.SetActive(true);


        }

        if(timer >= 46.0f)
        {
            text2.SetActive(false);
            text3.SetActive(true);

        }

        if(timer >= 49.0f)
        {
            text3.SetActive(false);
            text4.SetActive(true);

        }

        if(timer >= 52.0f)
        {

            canvas.SetActive(false);
            script.GetComponent<FirstPersonController>().enabled = true;
            husk.SetActive(false);
            light.SetActive(true);
            forTimer = false;
            door.SetBool("Open", true);

        }


    }


    public void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "Player")
        {
            forTimer = true;
            husk.SetActive(true);
            light.SetActive(true);
            wall1.GetComponent<Renderer>().material.mainTexture = otherWallTexture;
            wall2.GetComponent<Renderer>().material.mainTexture = newNewWallTexture;
            wall3.GetComponent<Renderer>().material.mainTexture = moreWallTexture;
            scare.Play();

        }


    }


}
