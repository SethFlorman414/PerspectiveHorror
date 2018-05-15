using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class pickupRaycast : NetworkBehaviour {

    public float maxDistance = 2f;
    public Camera cam;

    public Animator anim;

	void Update ()
    {
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

                    //hit.collider.gameObject.GetComponent<doorInteraction>().interact();

                    anim.SetBool("Open", true);

                    CmdRay(hit.collider.gameObject);

                }
            }
        }
	}

    [Command]
    void CmdRay(GameObject hit)
    {
        
                 hit.gameObject.GetComponent<doorInteraction>().interact();
              //  Destroy(hit);
         
    }




}
