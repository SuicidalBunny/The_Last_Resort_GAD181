using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoneyGrabber : MonoBehaviour
{
    //Links the script to the game manager
    public GameObject gameLink;
    //Used for the mouse offset
    private Vector3 mOffset;
    //Used to obtain the Z coordinates of the mouse
    private float mZCoord;

    //When mouse 1 is held down it checks the positioning of the mouse and grabs the gameObject it is hovering
    private void OnMouseDown()
    {
        //Sets the offset of the z coordinates in relation to the camera's position
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        //Moves the gameObject wherever the mouse moves to
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }

    //Grabs the mouse points (X and Y), followed by the Z axis and then returns the value 
    private Vector3 GetMouseWorldPos()
    {
        //Creates a vector 3 to obtain the X and Y position of the mouse
        Vector3 mousePoint = Input.mousePosition;
        //Grabs the z coordinates based off the already obtain Z coordinates
        mousePoint.z = mZCoord;
        //Returnes the position of the mouse
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    //When the mouse is moved it will move the object
    private void OnMouseDrag()
    {
        //Moves the object based off where the mouse has moved
        transform.position = GetMouseWorldPos() + mOffset;
    }

    //When the money hits this trigger, it will remove the gameObject, as well as add the money to the counter
    private void OnTriggerEnter(Collider other)
    {
        //Checks for if the gameObject is considered a bag
        if (other.gameObject.tag == "Bag")
        {
            //Tells the console that the cash has been deposited
            Debug.Log("cash deposited");
            //Tells the game manager to add $500 to the total cash amount
            gameLink.GetComponent<gameManager>().AddCash(500);
            //Deletes the cash brick that has been deposited
            this.gameObject.SetActive(false);
        }
    }
}
