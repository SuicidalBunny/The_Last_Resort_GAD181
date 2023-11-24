using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CardControls : MonoBehaviour, IDragHandler
{

    private RectTransform rectTransform;

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta;
    }

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            GetComponent<RectTransform>().anchoredPosition = new Vector2(-400, 0);
        }

    }
}
