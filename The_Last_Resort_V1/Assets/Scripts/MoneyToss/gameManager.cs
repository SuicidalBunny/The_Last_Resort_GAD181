using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject uiLink;
    public int money = 0;

    public void AddCash(int cashAmount)
    {
        money += cashAmount;
    }

}
