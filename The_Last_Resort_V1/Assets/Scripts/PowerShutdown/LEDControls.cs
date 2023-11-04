using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LEDControls : MonoBehaviour
{

    private float timer = 0.0f;

    private int LEDType = 0;

    public GameObject ledOff;
    public GameObject ledOn;
    public GameObject ledFail;

    // Start is called before the first frame update
    private void LEDController()
    {
        switch (LEDType)
        {
            case 0:
                ledOff.SetActive(true);
                break;
            case 1:
                ledOn.SetActive(true);

                break;
            case 2:
                ledFail.SetActive(true);

                break;
        }
    }

    private void LEDDisabler()
    {
        timer += Time.deltaTime;

        if (timer >= 5)
        {
            ledOn.SetActive(false);
            ledFail.SetActive(false);

            timer = 0.0f;
        }
    }
}
