using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockpickEnabler : MonoBehaviour
{

    public GameObject lockpickMinigame;

    public GameObject openDoor;

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
        if(other.gameObject.tag == "Player")
        {
            lockpickMinigame.SetActive(true);
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
            this.gameObject.SetActive(false);
        }
    }
}
