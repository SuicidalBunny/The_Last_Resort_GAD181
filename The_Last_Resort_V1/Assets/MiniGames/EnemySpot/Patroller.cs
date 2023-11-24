using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patroller : MonoBehaviour
{
    public GameObject camera;
    public GameObject deathCamera;
    public GameObject deathCanvas;
    public GameObject player;
    public Transform[] waypoints;
    public float speed;

    private int waypointIndex;
    private float dist;
    // Start is called before the first frame update
    void Start()
    {
        deathCanvas.SetActive(false); // Setting the Death camera and canvas to false at the start of the game
        deathCamera.SetActive(false);
        waypointIndex = 0;
        transform.LookAt(waypoints[waypointIndex].position);
    }

    
    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(transform.position, waypoints[waypointIndex].position); // For distance of waypoints
        if(dist < 1f){
            IncreaseIndex();
        }
        Patrol();
    }

    void Patrol()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime); // Rotates and positions the object currectly for movement

    }

    void IncreaseIndex(){
        waypointIndex++;
        if(waypointIndex >= waypoints.Length)
        {
            waypointIndex = 0;
        }
        transform.LookAt(waypoints[waypointIndex].position);
    }
     
    public void OnTriggerEnter(Collider other) // When they enter the colliders trigger
    {
       camera.SetActive(false); //sets the main camera off
       deathCamera.SetActive(true); // sets the death camera on
       deathCanvas.SetActive(true); // Sets the canvas on
       player.SetActive(false); //Sets the player to false to avoid any more triggers or player controls
        Cursor.lockState = CursorLockMode.None; // makes the cursor visable and unlocks it from the screen
        Cursor.visible = true;
        Debug.Log("You have been seen"); // Debug to see it the trigger functions
       
    }
}
