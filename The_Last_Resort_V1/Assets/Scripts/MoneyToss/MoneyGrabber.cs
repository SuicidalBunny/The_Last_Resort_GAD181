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

    //When mouse 1 is held down it checks the positioning of the mouse and moves the object in relation to it
    private void OnMouseDown()
    {
        //Sets the offset of the z coordinates in relation to the camera's position
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        //Moves the gameObject wherever the mouse moves to
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mOffset;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bag")
        {
            Debug.Log("cash deposited");

            gameLink.GetComponent<gameManager>().AddCash(500);

            this.gameObject.SetActive(false);
        }
    }
}
