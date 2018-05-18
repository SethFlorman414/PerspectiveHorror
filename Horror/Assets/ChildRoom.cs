using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildRoom : MonoBehaviour {

    // Use this for initialization

    public GameObject Wall;
    public GameObject Wall2;

    public Animator openDoor;

	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {



		
	}


    public void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "Child")
        {
            Wall.SetActive(true);
            Wall2.SetActive(true);
            openDoor.SetBool("Open", true);
            other.gameObject.SetActive(false);
        }
        else
        {
            openDoor.SetBool("Open", false);
        }
        

    }

}
