using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public GameObject gameLink;

    public TextMeshProUGUI moneyCounter;

    private int cash;

    // Update is called once per frame
    void Update()
    {
        GetMoney();

        moneyCounter.text = $"Money: {cash}";
    }

    void GetMoney()
    {
        cash = gameLink.GetComponent<gameManager>().money;
    }
}
