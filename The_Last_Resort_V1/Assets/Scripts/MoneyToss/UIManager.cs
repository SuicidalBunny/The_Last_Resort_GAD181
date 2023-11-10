using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    //Links the script to the game manager
    public GameObject gameLink;
    //Is used to display how much money will be displayed on the screen
    public TextMeshProUGUI moneyCounter;
    //Integer that holds the amount of cash the player will have
    private int cash;

    // Update is called once per frame
    void Update()
    {
        //Calls for the game to find out how much money the player has
        GetMoney();
        //Converts the amount of money the player has to readable text on the UI
        moneyCounter.text = $"Money: {cash}";
    }
    //When called, tells the program to find out how much money the player has
    void GetMoney()
    {
        //Communicates to the game manager to check how much money the player has
        cash = gameLink.GetComponent<gameManager>().money;
    }
}
