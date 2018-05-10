using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class playerSelection : NetworkBehaviour {


    [SyncVar]
    public bool serverIsPlayer;

    private void Start()
    {
       if(!isServer)
        {
            return;
        }
        int i = Random.Range(1, 3);
        if(i == 1)
        {
            serverIsPlayer = true;
        }
        else
        {
            serverIsPlayer = false;
        }
        GameObject[] GO = GameObject.FindGameObjectsWithTag("Player");
        for(int a = 0; a < GO.Length; a++)
        {
            GO[a].GetComponent<playerSelection>().serverIsPlayer = serverIsPlayer;
        }

    }

}
