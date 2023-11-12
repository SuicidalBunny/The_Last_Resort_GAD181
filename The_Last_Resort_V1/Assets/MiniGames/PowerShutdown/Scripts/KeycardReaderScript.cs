using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeycardReaderScript : MonoBehaviour
{
    //Timer that will be used to check how long the card has been in the swiper for
    private float swipeTimer = 0.0f;
    //These will be used for the minimum and maximum interpolation timer
    private float swipeInterpolationMin = 0.0f;
    private float swipeInterpolationMax = 0.0f;
    //Used for the fail counter
    private int failCount = 0;

    //This will link up the LED controller with the keycard reading script, to all control of LED variables
    public GameObject LEDLink;
    
    //Is called when the script first starts up
    private void Start()
    {
        //calls to generate a new min and max interpolation timer for the swipe time
        InterpolationGenerator();
    }

    //When called it will add 1 to the fail counter and check if the player has failed too many times
    private void SwipeFail()
    {
        //Adds 1 to the fail counter
        failCount++;
        //Tells the console how many times the player has failed
        Debug.Log($"Fail Counter: {failCount}");
        //Checks if the fail counter is more than or equal to 3 before making the game over screen
        if(failCount >= 3)
        {
            //Tells the console that the game is over
            Debug.Log("Game Over");
             SceneManager.LoadScene(1);
        }
    }

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

        //Checks if the swipe timer is inbetween the minimum and maximum interpolation time
        if (swipeTimer > swipeInterpolationMin && swipeTimer < swipeInterpolationMax)
        {
            //Tells the console the system is meant to pass
            Debug.Log("Pass");
            //This will tell the LED Controller to set the LED type to bring up the green light
            LEDLink.GetComponent<LEDControls>().LEDType = 1;

             SceneManager.LoadScene(4);
        }
        else
        {
            //Tells the console the system is meant to fail
            Debug.Log("Fail");
            //This tells the LED controller to set the led as the red light
            LEDLink.GetComponent<LEDControls>().LEDType = 2;
            //Adds 1 to the fail counter and checks to see if the player has failed the minigame
            SwipeFail();
        }

        //Resets the timer for the next attempt
        swipeTimer = 0.0f;
    }

    //Will create a random Interpolation time for how long to swipe the keycard for
    private void InterpolationGenerator()
    {
        //The minimum time will be randomly generated between 0.2 and 0.5 seconds
        swipeInterpolationMin = Random.Range(0.2f, 0.5f);
        //Maximum interpolation time will grab the minimum time and add 0.1 seconds to it
        swipeInterpolationMax = swipeInterpolationMin + 0.1f;
        //Tells the console what the minimum and maximum interpolation time is
        Debug.Log($"Min = {swipeInterpolationMin} Max = {swipeInterpolationMax}");
    }
}
