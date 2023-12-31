using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NFT_MiniGame : MonoBehaviour
{

    public Slider sliderDownload; // All the UI game objects that link to the script
    public GameObject buttonDownload;
    public GameObject error1;
    public GameObject error2;
    public GameObject error3;
    public GameObject error4;
    public GameObject error5;
    public GameObject error6;
    public GameObject error7;
    public GameObject error6help;
    public GameObject rockPet;
    public GameObject exitButton;
    int download = 0;

    public float timeLeft;
    public bool Timeron = false; 
    public TextMeshProUGUI TimerTxt;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;                       // Sets all popups errors to off so they dont active at the start of the game
            Cursor.lockState = CursorLockMode.None;
        rockPet.SetActive(false);
        error1.SetActive(false);
        error2.SetActive(false);
        error3.SetActive(false);
        error4.SetActive(false);
        error5.SetActive(false);
        error6.SetActive(false);
        error6help.SetActive(false);
        error7.SetActive(false);

        Timeron = true;
        timeLeft = 30; // Amount of time that is left (Used to change or set the timer)
    }

    // Update is called once per frame
    void Update()
    {
         sliderDownload.value = download; //Keeps the Download slider updated to the currect value

        if (Timeron) // If the time runs out or is on then the following happends
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                updateTimer(timeLeft);
            }
            else
            {
                Debug.Log("Time Over");
                timeLeft = 0;
                Timeron = false;
                SceneManager.LoadScene(1);
            }
        }

        if (error6 == true && timeLeft < 7) // if error6 is active and 5 seconds is left on the timer. Active the help 
        {
            error6help.SetActive(true);
        }
        
    }

    void updateTimer(float currentTime) //Updates the timer by seconds 
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("Time Left: " + "{0:00}:{1:00}", minutes, seconds);
    }
   
    public void SaveScore()
    {
        PlayerPrefs.SetInt("Score", 1000); // Creates and saves a player score for the leader board
    }

    public void ButtonPress()
    {
        download++;     // Download Value
        if (download == 50)
        {
            SaveScore();
           // SceneManager.LoadScene(3);
        }

        int popUpRan = Random.Range(1, 5); // 4 will never get picket. Only options between 1 and 4
        Debug.Log(popUpRan);
        if (popUpRan == 1) // if popup random = cirital 1 then do the if statement.
        {
            int popUpSelect = Random.Range(1, 100); // 100 will never get picket. Only options between 1 and 99
            Debug.Log(popUpSelect);

            if (popUpSelect >= 1 && popUpSelect <= 19)
            {
                error1.SetActive(true);
            }
            if (popUpSelect >= 20 && popUpSelect <= 39)
            {
                error2.SetActive(true);
                rockPet.SetActive(true);
            }
            if (popUpSelect >= 40 && popUpSelect <= 59)
            {
                error4.SetActive(true);

            }
            if (popUpSelect >= 60 && popUpSelect <= 79)
            {
                error6.SetActive(true);

            }
            if (popUpSelect >= 80 && popUpSelect <= 99)
            {
               // error7.SetActive(true);

            }
          
        }
    }

    public void ButtonClose() //Close buttons for all the popups (Need to redo for less code)
    {
        error1.SetActive(false);
    }
    public void ButtonClose2()
    {
        error2.SetActive(false);
    }
    public void ButtonClose3()
    {
        error3.SetActive(false);
    }
    public void ButtonClose4()
    {
        error4.SetActive(false);
    }

    public void ButtonClose5()
    {
        error5.SetActive(false);
    }

    public void ButtonClose6()
    {
        error6.SetActive(false);
        error6help.SetActive(false);
    }
    public void Button6Fake()
    {
        error5.SetActive(true);
    }
    public void ButtonClose7()
    {
        error7.SetActive(false);
    }
}
