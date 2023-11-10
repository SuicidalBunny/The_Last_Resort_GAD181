using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceVehicleScript : MonoBehaviour
{
    private float policeTimer = 0.0f;
    private float policeInterpolation = 5.0f;
    private bool policeOnScreen = false;

    public bool policeTriggered = false;

    public GameObject playerLink;

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
            PoliceMover();
        }
    }

    private void PoliceMover()
    {
        //Creates a new vector 3 at the current location to be used later
        Vector3 newPosition = transform.position;
        //Checks to see if the police are not on screen and if the police have been triggered
        if (policeOnScreen == false && policeTriggered == true)
        {
            //Changes the previous saved coordinated Z axis (Places it right behind the player vehicle)
            newPosition.z = -20;
            transform.position = newPosition;
            //Tells the game that the police are on screen
            policeOnScreen = true;
            //Makes a log showing that the police are on screen
            Debug.Log($"police on screen {policeOnScreen}");
        }
        //Checks to see if the police are on screen but they are not triggered
        else if(policeOnScreen == true && policeTriggered == false)
        {
            //Places the law enforcement out of the cameras way
            newPosition.z = -40;
            transform.position = newPosition;
            //Tells the game that the police are not on the screen anymore
            policeOnScreen = false;
            //Tells the console the on screen status of the police
            Debug.Log($"Police on screen {policeOnScreen}");
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
        }
    }
}
