using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeycardReaderScript : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Card Reading");
    }
}
