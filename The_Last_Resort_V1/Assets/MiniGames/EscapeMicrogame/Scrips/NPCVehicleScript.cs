using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NPCVehicleScript : MonoBehaviour
{

    private float time = 0.0f;
    private float interpolationPeriod = 0.01f;

    public GameObject policeLink;

    private void Start()
    {
        policeLink = GameObject.Find("LawEnforcement");
    }

    // Update is called once per frame
    void Update()
    {
        //Calls for the vehicles to be moved constantly
        VehicleMovement();
    }

    //Allows the vehicle to move with the terrain
    private void VehicleMovement()
    {
        //Ties the time float to deltaTime
        time += Time.deltaTime;
        if(gameObject.tag == "SlowCar")
        {
            //Checks to see if the timer has hit the interpolationPeriod
            if (time >= interpolationPeriod)
            {
                //Resets the timer to 0
                time = 0.0f;
                //Moves the object that the script is attatched to by 1 unit on the Z axis
                transform.position += new Vector3(0, 0, -0.3f);
            }
        }
        else if (gameObject.tag == "NormalCar")
        {
            //Checks to see if the timer has hit the interpolationPeriod
            if (time >= interpolationPeriod)
            {
                //Resets the timer to 0
                time = 0.0f;
                //Moves the object that the script is attatched to by 1 unit on the Z axis
                transform.position += new Vector3(0, 0, -0.5f);
            }
        }
        else if (gameObject.tag == "FastCar")
        {
            //Checks to see if the timer has hit the interpolationPeriod
            if (time >= interpolationPeriod)
            {
                //Resets the timer to 0
                time = 0.0f;
                //Moves the object that the script is attatched to by 1 unit on the Z axis
                transform.position += new Vector3(0, 0, -0.7f);
            }
        }
    }

    //Detects for any collisions that happen 
    private void OnTriggerEnter(Collider other)
    {
        //Tells the console a collision has happened
        Debug.Log("Collision Detected");
        //Looks to see if the object that is collided with is the player
        if (other.gameObject.tag == "Player")
        {
            //Runs the check to see if the player is to be arrested
            policeLink.GetComponent<PoliceVehicleScript>().PoliceArrestCheck();
            //Tells the game to trigger the police sequence
            policeLink.GetComponent<PoliceVehicleScript>().policeTriggered = true;
        }
        //Tells the console the kill barrier has been triggered
        Debug.Log("Kill Barrier Triggered");
        //Sets the current object as inactive, thus 'destroying' it
        this.gameObject.SetActive(false);
    }
}
