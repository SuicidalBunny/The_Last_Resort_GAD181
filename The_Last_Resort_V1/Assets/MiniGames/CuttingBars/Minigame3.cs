using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class Minigame3 : MonoBehaviour
{
    public GameObject cutButton;
    public GameObject Player;
    public GameObject miniGame3;
    public GameObject Door0;
    public GameObject Door1;
    public GameObject Door2;
    public GameObject Door3;
    public GameObject Door4;
    public GameObject Door5;
    public GameObject Door6;
    public GameObject Door7;
    public GameObject Door8;
    public GameObject Door9;
    int buttonPress = 0;

    // Start is called before the first frame update
    void Start()
    {
        miniGame3.SetActive(false);
        Door0.SetActive(true);
        Door1.SetActive(false);
        Door2.SetActive(false);
        Door3.SetActive(false);
        Door4.SetActive(false);
        Door5.SetActive(false);
        Door6.SetActive(false);
        Door7.SetActive(false);
        Door8.SetActive(false);
        Door9.SetActive(false);
    }
    public void OnTriggerStay(Collider other)
    {
        if(Input.GetKeyDown("e"))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            miniGame3.SetActive(true);
            Door0.SetActive(true);
        }
        
    }
    public void DoorCut()
    {
        buttonPress++;
        if(buttonPress== 1)
        {
            Door1.SetActive(true);
            Door0.SetActive(false);
        }
        if(buttonPress == 2)
        {
            Door1.SetActive(false);
            Door2.SetActive(true);
        }
        if(buttonPress == 3)
        {
            Door2.SetActive(false);
            Door3.SetActive(true);
        }
        if(buttonPress == 4)
        {
            Door3.SetActive(false);
            Door4.SetActive(true);
        }
        if(buttonPress == 5)
        {
            Door4.SetActive(false);
            Door5.SetActive(true);
        }
        if(buttonPress == 6)
        {
            Door5.SetActive(false);
            Door6.SetActive(true);
        }
        if(buttonPress == 7)
        {
            Door6.SetActive(false);
            Door7.SetActive(true);
        }
        if(buttonPress == 8)
        {
            Door7.SetActive(false);
            Door8.SetActive(true);
        }
        if(buttonPress == 9)
        {
            Door8.SetActive(false);
            Door9.SetActive(true);
        }
        if(buttonPress == 10)
        {
            miniGame3.SetActive(false);
            Door9.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
