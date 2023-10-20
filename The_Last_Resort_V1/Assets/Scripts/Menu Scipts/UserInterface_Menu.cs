using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UserInterface_Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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