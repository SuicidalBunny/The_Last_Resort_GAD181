using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PoliceVehicleScript : MonoBehaviour
{
    private float policeTimer = 0.0f;
    private float policeInterpolation = 5.0f;

    private float untouchedTime;
    private float untouchedInterpolation = 5.0f;
    public float movementMultiplier;

    public bool policeTriggered = false;

    public GameObject homePosition;
    public GameObject playerLink;
    private float speed;

    // Update is called once per frame
    void Update()
    {
        //Tells the console the status of the police
        Debug.Log(policeTriggered);
        if (policeTriggered == true)
        {
            PoliceTimer();
        }
        //Moves the law enforcement appropriately
        PoliceMover();
        //Calls to run the vehicle multipliers
        UntouchedMultiplier();
    }

    private void UntouchedMultiplier()
    {
        //Ties the time that the player has not been hit by deltatime
        untouchedTime += Time.deltaTime;
        //Checks to see if it has been 10 seconds since the player has been hit by
        if (untouchedTime >= 10)
        {
            movementMultiplier = 1.5f;
        }
        else if (untouchedTime >= untouchedInterpolation)
        {
            movementMultiplier = 1.25f;
        }
        else if (untouchedTime <= untouchedInterpolation)
        {
            movementMultiplier = 1.0f;
        }
    }

    //When called will get the police to move towards the player, effectively making them "chase" the player when hit
    private void PoliceMover()
    {
        //Checks to see if the police have been triggered
        if (policeTriggered == true)
        {
            //Changes the speed value so the police can slowly creep up
            speed = 2 * Time.deltaTime;
            //Tells the police car to move towards the player's vehicle
            transform.position = Vector3.MoveTowards(transform.position, playerLink.transform.position, speed);
        }
        //Checks to see if the police are not triggered at the moment
        else if (policeTriggered == false)
        {
            //Increases the movespeed of the police vehicle
            speed = 7.5f * Time.deltaTime;
            //Tells the police vehicle to move back to its home position
            transform.position = Vector3.MoveTowards(transform.position, homePosition.transform.position, speed);
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
            untouchedTime = 0.0f;
            //Sets the police trigger to false, thus disabling the police
            policeTriggered = false;
            PoliceMover();
        }
    }
    //Checks to see if the police are already triggered & arrests the player according to if they are or not, causing a game over
    public void PoliceArrestCheck()
    {
        //Checks to see if the police have been triggered onto the screen
        if(policeTriggered == true)
        {
            //Creates a debug log saying that the game is over
            //Will implement means of disabling controls when new movement system is implemented
            Debug.Log("Game Over");
            SceneManager.LoadScene(1);
        }
    }
}
