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

    public void PleaseWork()
    {
        if (pinLink.GetComponent<LockpickControls>().pinStrikeStatus == 4)
        {
            pinRaised = true;
            Debug.Log(pinRaised);
            transform.position += new Vector3(0, 50, 0);

            pinLink.GetComponent<LockpickControls>().pinStrikeStatus = 0;
            pinLink.GetComponent<LockpickControls>().controlsActive = false;
        }
        if (pinRaised == true)
        {
            pinTimer += Time.deltaTime;
            Debug.Log(pinTimer);
        }
        if (pinTimer >= 2)
        {
            transform.position -= new Vector3(0, 50, 0);
            pinTimer = 0;
            pinRaised = false;
            pinLink.GetComponent<LockpickControls>().controlsActive = true;
        }
    }

    public void PinSet(int x, int y)
    {
        GameObject pin = Instantiate(setPin, new Vector3(x, y, 0), Quaternion.Euler(0,0,0));
        pin.transform.SetParent(GameObject.FindGameObjectWithTag("LockpickMinigame").transform, false);

        pinTimer = 2;

        this.gameObject.SetActive(false);
    }
}
