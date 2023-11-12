using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UserInterface_Menu : MonoBehaviour
{

    public GameObject credits;    
    public GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        credits.SetActive(false);
        menu.SetActive(true);
    }


    public void Play() // Method for first button to start the next scene/ Level
    {
        SceneManager.LoadScene(1);
        Debug.Log("Next Scene");
    }

    public void Quit() // Method to quit the game
    {
        Application.Quit();
        Debug.Log("Game is exiting"); 
    }

    public void Credits() // Method to start the Credits
    {
        credits.SetActive(true);
        menu.SetActive(false);
    }

     public void Creditsback() // Method to start the Credits
    {
        credits.SetActive(false);
        menu.SetActive(true);
    }

    public void Options() // Method to open the Options Menu 
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}


// Hello World