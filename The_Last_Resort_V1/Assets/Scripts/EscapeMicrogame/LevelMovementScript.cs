using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LevelMovementScript : MonoBehaviour
{
    private float time = 0.0f;
    private float interpolationPeriod = 0.05f;
    private float timer = 0.0f;

    // Update is called once per frame
    void Update()
    {
        //Ties the time float to deltaTime
        time += Time.deltaTime;
        timer += Time.deltaTime;

        Debug.Log(timer);

        //Checks to see if the timer has hit the interpolationPeriod
        if(time >= interpolationPeriod) {
            //Resets the timer to 0
            time = 0.0f;
            //Moves the object that the script is attatched to by 1 unit on the Z axis
            transform.position += new Vector3(0, 0, -1);
        }
    }
}
