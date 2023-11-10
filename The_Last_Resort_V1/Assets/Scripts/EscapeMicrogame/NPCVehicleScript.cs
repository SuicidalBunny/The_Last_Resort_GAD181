using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NPCVehicleScript : MonoBehaviour
{

    private float time = 0.0f;
    private float interpolationPeriod = 0.01f;


    // Start is called before the first frame update
    void Start()
    {
        
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
        if(gameObject.tag == "NPCVehicle")
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
    }

    //Detects for any collisions that happen 
    private void OnTriggerEnter(Collider other)
    {
        //Tells the console a collision has happened
        Debug.Log("Collision Detected");
        //Looks to see if the object that is collided with is the player
        if (other.gameObject.tag == "Player")
        {
            //Tells the console the NPC vehicle is destroyed
            Debug.Log("NPC destroyed");

            //Destroys the NPC that was collided with
            DestroyObject();
        }
        //Checking if the trigger is the kill barrier
        else if (other.gameObject.tag == "KillBarrier")
        {
            //Tells the console the kill barrier has been triggered
            Debug.Log("Kill Barrier Triggered");
            //Destroys the NPC vehicle
            DestroyObject();
        }
    }
    //Destroys the Current object
    private void DestroyObject()
    {
        //Sets the current object as inactive, thus 'destroying' it
        this.gameObject.SetActive(false);
    }
}
