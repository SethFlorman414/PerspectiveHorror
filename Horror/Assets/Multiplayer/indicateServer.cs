using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class indicateServer : NetworkBehaviour {

    public Text txt;
    public MeshRenderer mesh;
    public GameObject part;

	// Use this for initialization
	void Start () {
		if(!isServer)
        {
            if (isLocalPlayer)
            {
                mesh.enabled = false;
                part.SetActive(false);
                txt.text = "client";
            }
            else
            {
                mesh.enabled = true;
                part.SetActive(false);
                txt.text = "";
            }
        }
        if (isServer)
        {
            if (isLocalPlayer)
            {
                mesh.enabled = true;
                part.SetActive(false);
                txt.text = "server";
            }
            else
            {
                mesh.enabled = false;
                part.SetActive(true);
                txt.text = "";
            }
        }
    }
	
	
}
