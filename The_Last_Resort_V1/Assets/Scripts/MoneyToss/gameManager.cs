using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    //Links the game manager to the User Interface
    public GameObject uiLink;
    //Is used to store how much money the player has
    public int money = 0;

    //When called, adds the amount of money that the program calls for
    public void AddCash(int cashAmount)
    {
        //Adds the desired cash amount to the total money count
        money += cashAmount;
    }

}
