using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class NFT_MiniGame : MonoBehaviour
{

    public Slider sliderDownload;
    public GameObject buttonDownload;
    public GameObject error1;
    public GameObject error2;
    public GameObject error3;
    public GameObject error4;
    public GameObject error5;
    public GameObject error6;
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
        Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        rockPet.SetActive(false);
        error1.SetActive(false);
        error2.SetActive(false);
        error3.SetActive(false);
        error4.SetActive(false);
        error5.SetActive(false);
        error6.SetActive(false);
        error6help.SetActive(false);

        Timeron = true;
        timeLeft = 30;
    }

    // Update is called once per frame
    void Update()
    {
         sliderDownload.value = download;

        if (Timeron)
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
            }
        }

        if (error6 == true && timeLeft < 5)
        {
            error6help.SetActive(true);
        }
        
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("Time Left: " + "{0:00}:{1:00}", minutes, seconds);
    }

    public void ButtonPress()
    {
        download++;
        if (download == 5)
        {
            error1.SetActive(true);
        }
        if (download == 20)
        {
            error2.SetActive(true);
            rockPet.SetActive(true);
        }
        if (download == 30)
        {
            error4.SetActive(true);
            
        }
        if (download == 45)
        {
            error6.SetActive(true);
            
        }
    }

    public void ButtonClose()
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
}
