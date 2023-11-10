using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVehicleScript : MonoBehaviour
{

    private float speed = 10.0f;
    public GameObject character;

    public GameObject policeLink;

    // Update is called once per frame
    void Update()
    {
        //Enables the vehicle movement controls
        VehicleMovement();
    }
    //Allows for the vehicle to be moved left and right
    private void VehicleMovement()
    {
        //Checks if the "A" key is being held down
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Move Left");
            //Makes the vehicle move right based off the speed float and deltaTime
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        //Checks if the "D" key is being held down
        else if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Move Right");
            //Makes the object move left based off the speed variable and deltaTime
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
    //Checks for any collisions that the player vehicle enters with a trigger
    private void OnTriggerEnter(Collider other)
    {
        //Checks to see if the player has collided with an NPC Vehicle
        if(other.gameObject.tag == "NPCVehicle")
        {
            //Runs the check to see if the player is to be arrested
            policeLink.GetComponent<PoliceVehicleScript>().PoliceArrestCheck();
            //Tells the game to trigger the police sequence
            policeLink.GetComponent<PoliceVehicleScript>().policeTriggered = true;
        }
    }
}
