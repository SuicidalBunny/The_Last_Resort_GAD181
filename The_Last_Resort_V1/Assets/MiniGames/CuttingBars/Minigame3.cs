using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame3 : MonoBehaviour
{
    public GameObject Player;
    public GameObject miniGame3;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnTriggerStay(Collider other)
    {
        if(Input.GetKeyDown("e"))
        {
            miniGame3.SetActive(true);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
