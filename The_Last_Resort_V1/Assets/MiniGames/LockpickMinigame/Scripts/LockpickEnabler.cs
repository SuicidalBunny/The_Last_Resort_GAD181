using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockpickEnabler : MonoBehaviour
{

    public GameObject lockpickMinigame;

    public GameObject openDoor;

    public GameObject gameLink;

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
            gameLink.GetComponent<LockpickControls>().GameRestart();
            doorType = 1;
        }
        else if (other.gameObject.tag == "Player")
        {
            lockpickMinigame.SetActive(true);
            gameLink.GetComponent<LockpickControls>().GameRestart();
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

            this.gameObject.SetActive(false);
        }
    }
}
