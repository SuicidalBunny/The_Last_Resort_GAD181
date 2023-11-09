using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoneyGrabber : MonoBehaviour
{
    public GameObject gameLink;

    private Vector3 mOffset;

    private float mZCoord;

    private void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
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
