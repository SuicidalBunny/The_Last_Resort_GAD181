using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LEDControls : MonoBehaviour
{
    //Timer used for holding the light on for a set amount of time
    private float timer = 0.0f;
    //Integer used in selecting the correct LED type
    public int LEDType = 0;
    //GameObjects used for linking the LED's so their corresponding sprites
    public GameObject ledOff;
    public GameObject ledPass;
    public GameObject ledFail;

    private void Update()
    {
        //Constantly looking to see what LED should be active at any time
        LEDController();
    }

    // Start is called before the first frame update
    private void LEDController()
    {
        //Checks what numeric value LEDType is, whilst 
        switch (LEDType)
        {
            case 1:
                //Turns on the led to indicate the player has passed the activity
                ledPass.SetActive(true);
                //calls for the light to be disabled soon after
                LEDDisabler();
                break;
            case 2:
                //turns on the led to indicate that the player has failed the activity
                ledFail.SetActive(true);
                //calls for the led to be soon disabled after
                LEDDisabler();
                break;
        }
    }
    
    //when called, allows the LED controller to disable the active LED and reset the timer
    private void LEDDisabler()
    {
        //Links the timer to deltaTime
        timer += Time.deltaTime;

        //Checks to see if one second or more has passed on the timer
        if(timer >= 1)
        {
            //Tells the console that the LED is meant to shut off
            Debug.Log("LEDOff");

            //Tells both the pass and fail LED's to turn themselves off
            ledPass.SetActive(false);
            ledFail.SetActive(false);

            //Resets which LED Type should be active, as well as the timer
            LEDType = 0;
            timer = 0.0f;
        }
    }
}
