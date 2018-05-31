using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class disableObjects : NetworkBehaviour {

    public GameObject[] GA;

	void Start () {
        if (!isServer)
        {
            for (int i = 0; i < GA.Length; i++)
            {
                GA[i].SetActive(false);
            }
        }
	}

}
