using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    private float time = 0.0f;
    private float interpolationPeriod = 1.0f;
    private int vehicleLocationSpawner = 0;
    private int vehicleChoice;

    public GameObject slowCar;
    public GameObject normalCar;
    public GameObject fastCar;

    // Update is called once per frame
    void Update()
    {
        //Ties the time float to deltaTime
        time += Time.deltaTime;

        //Checks to see if the timer has hit the interpolationPeriod
        if (time >= interpolationPeriod)
        {
            Debug.Log("5 seconds passed");
            //Calls to create random X axis location
            RandomLocation();
            //Instantiates a new vehicle
            SpawnVehicle();
        }

    }
    //Creats a random spawn location on the X axis
    private void RandomLocation()
    {
        //uses a random number generator to create the spawn location between -13 and 13
        vehicleLocationSpawner = Random.Range(-12, 12);
    }

    private void RandomVehicle()
    {
        //Changes the vehicle choice randomly between 0 and 3 in order to select which of the 3 vehicle prefabs get chosen later
        vehicleChoice = Random.Range(0, 3);
        
        //Creates a log of the number that has been generated in the console
        Debug.Log(vehicleChoice);
    }
    private void SpawnVehicle()
    {
        //Resets the timer to 0
        time = 0.0f;
        //Generates a numerical value for what car type will be spawned
        RandomVehicle();
        //Grabs the numerical value generated to decide on what vehicle gets spawned
        switch (vehicleChoice)
        {
            case 0:
                //Creates a slow vehicle using the random X axis and some other set paramaters
                Instantiate(slowCar, new Vector3(vehicleLocationSpawner, 1, 100), Quaternion.Euler(0, 180, 0));
                Debug.Log("slowCar Spawned");
                break;

            case 1:
                //Creates a normal speed vehicle using the random X axis and some other set paramaters
                Instantiate(normalCar, new Vector3(vehicleLocationSpawner, 1, 100), Quaternion.Euler(0, 180, 0));
                Debug.Log("normalCar Spawned");
                break;

            case 2:
                //Creates a fast car using the random X axis and some other set paramaters
                Instantiate(fastCar, new Vector3(vehicleLocationSpawner, 1, 100), Quaternion.Euler(0, 180, 0));
                Debug.Log("fastCar Spawned");
                break;
        }
    }
}
