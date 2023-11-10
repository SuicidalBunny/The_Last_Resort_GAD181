using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    private float time = 0.0f;
    private float interpolationPeriod = 1.0f;
    private int vehicleLocationSpawner = 0;

    public GameObject prefab;

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
        vehicleLocationSpawner = Random.Range(-13, 13);
    }
    private void SpawnVehicle()
    {
        //Resets the timer to 0
        time = 0.0f;
        //Creates the vehicle prefab using the random X axis and some other set paramaters
        Instantiate(prefab, new Vector3(vehicleLocationSpawner, 1, 100), Quaternion.Euler(0, 180, 0));
        Debug.Log("Vehicle Spawned");
    }
}
