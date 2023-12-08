using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockpickEnabler : MonoBehaviour
{

    public GameObject lockpickMinigame;

    public GameObject openDoor;

    public int doorType;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && this.gameObject.tag == "Door")
        {
            lockpickMinigame.SetActive(true);
            doorType = 1;
        }
        else if (other.gameObject.tag == "Player" && this.gameObject.tag == "Door2")
        {
            lockpickMinigame.SetActive(true);
            doorType = 2;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        lockpickMinigame.SetActive(false);
    }

    public void DoorOpen()
    {
        if(this.gameObject.tag == "Door")
        {
            openDoor.SetActive(true);
            lockpickMinigame.SetActive(false);
            doorType = 0;

            this.gameObject.SetActive(false);
        }
    }

    public void Door2Open()
    {
        if(this.gameObject.tag == "Door2")
        {
            openDoor.SetActive(true);
            lockpickMinigame.SetActive(false);
            doorType = 0;

            this.gameObject.SetActive(false);
        }
    }
}
