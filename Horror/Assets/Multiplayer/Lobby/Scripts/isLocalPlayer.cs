using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class isLocalPlayer : NetworkBehaviour {

    public GameObject[] notlocalDestroy;
    public Behaviour[] notLocalDisable;

	// Use this for initialization
	void Start ()
    {

        if (!isLocalPlayer)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationZ
                | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezePositionX |
                RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezePositionY;
            for(int i = 0; i < notlocalDestroy.Length; i++)
            {
                notlocalDestroy[i].SetActive(false);
            }
            for(int i = 0; i < notlocalDestroy.Length; i++)
            {
                notLocalDisable[i].enabled = false;
            }
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
