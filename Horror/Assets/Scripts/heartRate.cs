using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartRate : MonoBehaviour {


    //lower bound heart Rate
    private int baseHeartRate = 70;
    //highest normal heart rate
    public int heartRateUpperBound = 100;
    //the current heart rate
    // private int currentUpperBound;

    //scare multiplier to the heartRateJump
    public int spikeMultiplier = 2;
    private int currentHeartRate;

    //specifies the way the HR will be adding/subtracting
    //tru = +2
    //fal = --
    private bool direction;

    private float timer;


    void Start()
    {
        currentHeartRate = baseHeartRate;
        direction = true;
    }

    // Update is called once per frame
    void Update()
    {
        checkHR();
        if (currentHeartRate <= heartRateUpperBound)
        {
            if (direction)
            {
                goUp();
            }
            else if (!direction)
            {
                goDown();
            }
        }
        else
        {
            timer += Time.deltaTime;
            if(timer > 0.5f)
            {
                timer = 0;
                goDown();
            }
        }
        Debug.Log(currentHeartRate);


    }

    //call this from external script
    public void Scare(int heartRateJump)
    {
        int finalAdd;
        finalAdd = heartRateJump;
        finalAdd *= spikeMultiplier;
        currentHeartRate += finalAdd;
    }

    //check if the player will exceed the maximum HR
    void checkHR()
    {

    }

    //add 2 to currentHeartRate
    void goUp()
    {
        currentHeartRate ++;
        if(currentHeartRate >= heartRateUpperBound)
        {
            currentHeartRate = heartRateUpperBound;
            direction = false;
        }
    }
    //subtract 1 from currentHeartRate
    void goDown()
    {
        currentHeartRate--;
        if (currentHeartRate <= baseHeartRate)
        {
            currentHeartRate = baseHeartRate;
            direction = true;
        }
    }




}
