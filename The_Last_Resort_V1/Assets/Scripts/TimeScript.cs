using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeScript : MonoBehaviour
{
    
    public float timeLeft;
    public bool Timeron = false;
    public TextMeshProUGUI TimerTxt;
    // Start is called before the first frame update
    void Start()
    {
        Timeron = true;
        timeLeft = 30;
    }

    // Update is called once per frame
    void Update()
    {
        if(Timeron)
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
                SceneManager.LoadScene(0);
            }
        }
    }   


    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("Time Left: " + "{0:00}:{1:00}", minutes, seconds);
    }
}
