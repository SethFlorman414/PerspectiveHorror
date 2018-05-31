using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class terra : MonoBehaviour {

    public GameObject grass;
    public GameObject rock;
    public GameObject iron;
    public GameObject copper;
    public GameObject gold;
    public GameObject food;
    public int maxX = 5;
    public int maxZ = 5;



	// Use this for initialization
	void Start ()
    {
        Vector3 pos = Vector3.zero;
        choose(pos);
        float currentY = 0;
        for (int z = 0; z < maxZ; z++)
        {
            for (int x = 0; x < maxX; x++)
            {
                pos = new Vector3(x, currentY, z);
                choose(pos);
                
            }
        }
	}




    void choose(Vector3 pos)
    {
        int rand = Random.Range(0, 100);
        switch(rand)
        {
            case 0:
                GameObject newRock = rock;
                newRock.transform.localScale = new Vector3(1, 1.3f, 1);
                Instantiate(newRock, pos, Quaternion.identity);
                break;
            case 1:
                GameObject newRock2 = rock;
                newRock2.transform.localScale = new Vector3(1, 2.5f, 1);
                Instantiate(newRock2, pos, Quaternion.identity);
                break;
            case 2:
                GameObject newRock3 = rock;
                newRock3.transform.localScale = new Vector3(1, 1.5f, 1);
                Instantiate(newRock3, pos, Quaternion.identity);
                break;
            case 3:
                GameObject newRock4 = rock;
                newRock4.transform.localScale = new Vector3(1, 2f, 1);
                Instantiate(newRock4, pos, Quaternion.identity);
                break;
            case 4:
                Instantiate(rock, pos, Quaternion.identity);
                break;

            case 5:
                Instantiate(iron, pos, Quaternion.identity);
                break;
            case 6:
                Instantiate(iron, pos, Quaternion.identity);
                break;
            case 7:
                Instantiate(iron, pos, Quaternion.identity);
                break;

            case 8:
                Instantiate(copper, pos, Quaternion.identity);
                break;
            case 9:
                Instantiate(copper, pos, Quaternion.identity);
                break;
            case 10:
                Instantiate(copper, pos, Quaternion.identity);
                break;

            case 11:
                Instantiate(food, pos, Quaternion.identity);
                break;
            case 12:
                Instantiate(food, pos, Quaternion.identity);
                break;

            case 13:
                Instantiate(gold, pos, Quaternion.identity);
                break;


            case 14:
                GameObject newRock7 = rock;
                newRock7.transform.localScale = new Vector3(1, 2.7f, 1);
                Instantiate(newRock7, pos, Quaternion.identity);
                break;
            case 15:
                GameObject newRock8 = rock;
                newRock8.transform.localScale = new Vector3(1, 2.8f, 1);
                Instantiate(newRock8, pos, Quaternion.identity);
                break;
            case 16:
                GameObject newRock9 = rock;
                newRock9.transform.localScale = new Vector3(1, 3f, 1);
                Instantiate(newRock9, pos, Quaternion.identity);
                break;

            case 17:
                GameObject newRocka = rock;
                newRocka.transform.localScale = new Vector3(1, 2.7f, 1);
                Instantiate(newRocka, pos, Quaternion.identity);
                break;
            case 18:
                GameObject newRockb = rock;
                newRockb.transform.localScale = new Vector3(1, 2.8f, 1);
                Instantiate(newRockb, pos, Quaternion.identity);
                break;
            case 19:
                GameObject newRockc = rock;
                newRockc.transform.localScale = new Vector3(1, 3f, 1);
                Instantiate(newRockc, pos, Quaternion.identity);
                break;



            default:

                GameObject i = (GameObject)Instantiate(grass, pos, Quaternion.identity);
                
                break;
        }

    }
	
    





}
