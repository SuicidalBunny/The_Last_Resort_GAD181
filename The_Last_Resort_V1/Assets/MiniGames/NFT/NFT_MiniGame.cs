using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class NFT_MiniGame : MonoBehaviour
{

    public Slider sliderDownload;
    public GameObject buttonDownload;
    public GameObject error1;
    public GameObject error2;
    public GameObject rockPet;
    public GameObject exitButton;
    int download = 0;
    // Start is called before the first frame update
    void Start()
    {
        rockPet.SetActive(false);
        error1.SetActive(false);
        error2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
         sliderDownload.value = download; 
    }

    public void ButtonPress()
    {
        download++;
        if (download == 10)
        {
            error1.SetActive(true);
        }
        if (download == 20)
        {
            error2.SetActive(true);
            rockPet.SetActive(true);
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

}
