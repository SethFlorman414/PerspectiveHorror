using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupRaycast : MonoBehaviour {


	void Update ()
    {
        Camera cam = Camera.main;
        RaycastHit hit;
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        if(Physics.Raycast(ray,out hit))
        {
            if (hit.collider.tag == "Interact")
            {
                //text or something to say you can interact
                if (Input.GetButtonDown("Fire1"))
                {

                }
            }
        }
	}




}
