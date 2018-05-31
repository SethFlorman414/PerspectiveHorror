using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwaway : MonoBehaviour {

	// Use this for initialization
	void Start () {
        float rotationX = Random.Range(0,90);
        transform.localRotation = Quaternion.AngleAxis(rotationX, Vector3.up);
	}
	
	
}
