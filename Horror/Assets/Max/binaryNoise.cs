using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class binaryNoise : MonoBehaviour {
    public int x;
    public int y;
    public GameObject cube;
    public int bl;
    public int wh;


	void Start ()
    {

        for (int b = 0; b < y; b++)
        {
            for (int i = 0; i < x; i++)
            {
                GameObject newObj = (GameObject)Instantiate(cube, new Vector2(i, b), Quaternion.identity);
                int a = getNum();
                switch(a)
                {
                    case 0:
                        newObj.GetComponent<MeshRenderer>().material.color = Color.white;
                        wh++;
                        break;

                    case 1:
                        newObj.GetComponent<MeshRenderer>().material.color = Color.black;
                        bl++;
                        break;

                }
                ///Destroy(newObj, 0.03f);
            }
        }
	}


	int getNum()
    {
        int i = Random.Range(0, 2);
        return i;
    }

}
