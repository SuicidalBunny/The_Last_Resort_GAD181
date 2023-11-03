using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CardControls : MonoBehaviour, IDragHandler
{
    //Checks to see if the player has clicked and is dragging an item
    public void OnDrag(PointerEventData eventData)
    {
        //Tells the program to move the object wherever the mouse is dragging it
        transform.position = eventData.position;
    }

}
