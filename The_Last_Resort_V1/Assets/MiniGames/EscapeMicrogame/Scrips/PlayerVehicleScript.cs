using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVehicleScript : MonoBehaviour
{
    private CharacterController controller;
    private float speed = 20.0f;

    private void Start()
    {
        //Obtains the character controller used for the players vehicle to allow movement
        controller = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Loads the controller for the players vehicle
        VehicleMovement();
    }
    //Allows for the vehicle to be moved left and right
    private void VehicleMovement()
    {
        //Tells the game to get the new 'X' axis for the player vehicle
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0);
        //Moves the vehicle based off of the 'X' axis obtained from before, along with the speed
        controller.Move(move * Time.deltaTime * speed);
    }
}
