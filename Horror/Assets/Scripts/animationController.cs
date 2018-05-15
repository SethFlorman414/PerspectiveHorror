using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class animationController : MonoBehaviour {

    public Animator _Animator;
    public bool isWalking;
    public FirstPersonController _firstPersonController;







	
	// Update is called once per frame
	void Update ()
    {
        Vector2 input = GetInput();
        bool x = X_Walking(input.x);
        bool y = X_Walking(input.y);
	}

    Vector2 GetInput()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector2 ReturnValue = new Vector2(x, y);
        return ReturnValue;
    }

    bool X_Walking(float x)
    {
        int y = Mathf.RoundToInt(x);
        switch (y) { 
            case 0:
            return false;
            case 1:
            return true;
            }
        return false;
    }



}
