using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class spawnPeople : NetworkBehaviour {
    public GameObject spawn1;
    // Use this for initialization
    
    void Start() {
        NetworkLobbyPlayer myPlayerInfo = GameObject.FindObjectOfType<NetworkLobbyManager>().lobbyPlayerPrefab;

        NetworkServer.AddPlayerForConnection(myPlayerInfo.connectionToServer, spawn1, myPlayerInfo.playerControllerId);
}

	
}
