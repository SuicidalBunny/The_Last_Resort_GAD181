using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinScript : MonoBehaviour
{
    private float pinTimer;
    public bool pinRaised = false;

    public GameObject setPin;
    public GameObject pinLink;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Checks the pin strike status to see if it is as 4 before calling to knock it up
    public void PinRaise()
    {
        if (pinLink.GetComponent<LockpickControls>().pinStrikeStatus == 4)
        {
            pinRaised = true;
            Debug.Log(pinRaised);
            transform.position += new Vector3(0, 50, 0);

            pinLink.GetComponent<LockpickControls>().pinStrikeStatus = 0;
            pinLink.GetComponent<LockpickControls>().controlsActive = false;
        }
        //A timer starts when the pin is raised to count how long it should be up there for
        if (pinRaised == true)
        {
            pinTimer += Time.deltaTime;
            Debug.Log(pinTimer);
        }
        //After 2 seconds the pin will drop down
        if (pinTimer >= 2)
        {
            transform.position -= new Vector3(0, 50, 0);
            pinTimer = 0;
            pinRaised = false;
            pinLink.GetComponent<LockpickControls>().controlsActive = true;
        }
    }

    //Creates the new set pin whilst disabling the interactible pin
    public void PinSet(int x, int y)
    {
        GameObject pin = Instantiate(setPin, new Vector3(x, y, 0), Quaternion.Euler(0,0,0));
        pin.transform.SetParent(GameObject.FindGameObjectWithTag("LockpickMinigame").transform, false);

        pinTimer = 2;

        this.gameObject.SetActive(false);
    }
}
