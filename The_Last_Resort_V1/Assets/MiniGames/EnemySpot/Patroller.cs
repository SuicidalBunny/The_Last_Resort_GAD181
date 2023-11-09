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
    public int speed;

    private int waypointIndex;
    private float dist;
    // Start is called before the first frame update
    void Start()
    {
        deathCanvas.SetActive(false);
        deathCamera.SetActive(false);
        waypointIndex = 0;
        transform.LookAt(waypoints[waypointIndex].position);
    }

    
    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(transform.position, waypoints[waypointIndex].position);
        if(dist < 1f){
            IncreaseIndex();
        }
        Patrol();
    }

    void Patrol()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }

    void IncreaseIndex(){
        waypointIndex++;
        if(waypointIndex >= waypoints.Length)
        {
            waypointIndex = 0;
        }
        transform.LookAt(waypoints[waypointIndex].position);
    }
     
    public void OnTriggerEnter(Collider other)
    {
       camera.SetActive(false);
       deathCamera.SetActive(true);
       deathCanvas.SetActive(true);
       player.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Debug.Log("You have been seen");
       
    }
}
