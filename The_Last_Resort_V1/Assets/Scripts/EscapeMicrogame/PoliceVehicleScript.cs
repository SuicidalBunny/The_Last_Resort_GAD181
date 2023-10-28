using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceVehicleScript : MonoBehaviour
{
    private float policeTimer = 0.0f;
    private float policeInterpolation = 5.0f;

    public bool policeTriggered = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Tells the console the status of the police
        Debug.Log(policeTriggered);
        if (policeTriggered == true)
        {
            PoliceTimer();
        }
    }
    //Checks if the police have been out for enough time & disables the police trigger
    private void PoliceTimer()
    {
        //Connects the police timer to deltaTime
        policeTimer += Time.deltaTime;
        //Checks if the timer has hit the interpolation timer
        if (policeTimer >= policeInterpolation)
        {
            policeTimer = 0.0f;
            //Sets the police trigger to false, thus disabling the police
            policeTriggered = false;
        }
    }
}
