using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupRaycast : MonoBehaviour {

    public float maxDistance = 2f;

	void Update ()
    {
        Camera cam = Camera.main;
        RaycastHit hit;
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        if(Physics.Raycast(ray,out hit,maxDistance))
        {
            if (hit.collider.tag == "Interact")
            {
                //text or something to say you can interact
                Debug.Log("interact!");
                if (Input.GetKeyDown(KeyCode.E) && hit.collider.gameObject.layer == 9)//door layer
                {
                    hit.collider.gameObject.GetComponent<doorInteraction>().interact();
                }
            }
        }
	}




}
