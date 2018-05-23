using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSway : MonoBehaviour {

    // Use this for initialization

    public float smooth = 3.0f;
    public float tiltAngle = 5.0f;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float tilt = -Input.GetAxis("Mouse X") * tiltAngle;
        Quaternion targetRotation = Quaternion.Euler(0f, tilt, tilt);
        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, Time.deltaTime * smooth);

    }
}
