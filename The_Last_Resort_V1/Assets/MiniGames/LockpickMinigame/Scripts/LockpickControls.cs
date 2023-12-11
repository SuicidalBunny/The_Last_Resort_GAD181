using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class LockpickControls : MonoBehaviour
{

    public GameObject pin1Link;
    public GameObject pin2Link;
    public GameObject pin3Link;
    public GameObject pin4Link;

    public bool lock1Unlocked = false;
    public bool lock2Unlocked = false;
    public bool lock3Unlocked = false;
    public bool lock4Unlocked = false;

    public GameObject doorLink;

    public int pinStrikeStatus;

    public int pinNumber = 1;

    public bool controlsActive = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Enables the movement controls for the pick
        PickMover();
        PinStrike();
        PinSet();
        PinMovement();
        PinChecker();
    }

    private void PickMover()
    {
        if(controlsActive == true)
        {
            //Checks if the selected pin is more than or equal to 2 before it changes down a pin after they have pressed the left movement key
            if (Input.GetKeyDown(KeyCode.LeftArrow) && pinNumber >= 2)
            {
                //Lowers the pin count down by one
                pinNumber--;
                //Visually moves the pick around
                transform.position += new Vector3(-200, 0, 0);
                //Logs the pin number to the console
                Debug.Log(pinNumber);
            }
            //Checks to see if the pin selected is less than or equal to 3 before moving up a pin after they have pressed the right movement key
            else if (Input.GetKeyDown(KeyCode.RightArrow) && pinNumber <= 3)
            {
                //Moves the pin count up by one
                pinNumber++;
                //Visually moves the pick around
                transform.position += new Vector3(200, 0, 0);
                //Logs the pin number in the console
                Debug.Log($"Pin Number: {pinNumber}");
            }
        }
    }

    //When called will create a random range between 1 and 4.
    private void PinStrike()
    {
        if(Input.GetKeyDown(KeyCode.Space) && controlsActive == true)
        {
            pinStrikeStatus = Random.Range(1, 5);
            Debug.Log(pinStrikeStatus);
        }
    }

    //When called, will grab the pin number that is being hovered over and call for the pin to be raised
    private void PinMovement()
    {
        switch (pinNumber)
        {
            case 1:
                pin1Link.GetComponent<PinScript>().PinRaise();
                break;

            case 2:
                pin2Link.GetComponent<PinScript>().PinRaise();
                break;

            case 3:
                pin3Link.GetComponent<PinScript>().PinRaise();
                break;

            case 4:
                pin4Link.GetComponent<PinScript>().PinRaise();
                break;
        }
    }

    //When the player presses the E key, it will check to see if the pin is raised and set the pin in place, whilst telling the game the pin is unlocked
    private void PinSet()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (pin1Link.GetComponent<PinScript>().pinRaised == true)
            {
                pin1Link.GetComponent<PinScript>().PinSet(-400, 100);
                lock1Unlocked = true;
            }
            else if (pin2Link.GetComponent<PinScript>().pinRaised == true)
            {
                pin2Link.GetComponent<PinScript>().PinSet(-200, 100);
                lock2Unlocked = true;
            }
            else if (pin3Link.GetComponent<PinScript>().pinRaised == true)
            {
                pin3Link.GetComponent<PinScript>().PinSet(0, 100);
                lock3Unlocked = true;
            }
            else if (pin4Link.GetComponent<PinScript>().pinRaised == true)
            {
                pin4Link.GetComponent<PinScript>().PinSet(200, 100);
                lock4Unlocked = true;
            }
        }
    }

    //Checks to see if all four pins are unlocked before opening the door
    private void PinChecker()
    {
        if(lock1Unlocked == true && lock2Unlocked == true && lock3Unlocked == true && lock4Unlocked == true)
        {
            if(doorLink.GetComponent<LockpickEnabler>().doorType == 1)
            {
                doorLink.GetComponent<LockpickEnabler>().DoorOpen();
            }
        }
    }

    //Resets the minigame when called
    public void GameRestart()
    {
        lock1Unlocked = false;
        lock2Unlocked = false;
        lock3Unlocked = false;
        lock4Unlocked = false;

        pin1Link.SetActive(true);
        pin2Link.SetActive(true);
        pin3Link.SetActive(true);
        pin4Link.SetActive(true);

        GameObject[] gos = GameObject.FindGameObjectsWithTag("SetPin");
        foreach (GameObject go in gos)
        {
            Destroy(go);
        }
    }
}
