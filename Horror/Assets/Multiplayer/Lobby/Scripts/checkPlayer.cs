using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPlayer : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;

    private void Update()
    {
       if(GetComponent<playerSelection>().serverIsPlayer)
        {
            player2.SetActive(true);
        }
       else if (!GetComponent<playerSelection>().serverIsPlayer)
        {
            player1.SetActive(true);
        }
    }

}
