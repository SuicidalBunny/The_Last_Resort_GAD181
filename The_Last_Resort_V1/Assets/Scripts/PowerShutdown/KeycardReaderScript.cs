using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeycardReaderScript : MonoBehaviour
{
    //Timer that will be used to check how long the card has been in the swiper for
    private float swipeTimer = 0.0f;


    //Checks if a collider is within the trigger zone
    public void OnTriggerStay2D(Collider2D collision)
    {
        SwipeEnabler();
    }

    //Checks if an collider has exited the trigger
    public void OnTriggerExit2D(Collider2D collision)
    {
        SwipeTimeChecker();
    }

    //Checks to start the timer for the swipe when called
    private void SwipeEnabler()
    {
        //Tells the console that a trigger has been detectes
        Debug.Log("Card Trigger Detected");

        //Reads how many seconds has passed whilst in the trigger
        swipeTimer += Time.deltaTime;
    }

    //Checks whether the player has passed or failed depending on how long it takes for the swipe
    private void SwipeTimeChecker()
    {
        //Tells the console how long the card was in the trigger zone for
        Debug.Log($"Timer = " + swipeTimer);

        //Checks if the swipe timer is inbetween 0.3 and 0.4 seconds
        if (swipeTimer > 0.3f && swipeTimer < 0.4f)
        {
            //Tells the console the system is meant to pass
            Debug.Log("Pass");
        }
        else
        {
            //Tells the console the system is meant to fail
            Debug.Log("Fail");
        }

        //Resets the timer for the next attempt
        swipeTimer = 0.0f;
    }
}
