using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TextHoverModifier : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{

    private Text text;
    private Color startingColor;
    private int startingSize;
    public Color hoverColor;
    public int textSize; 

    void Start()
    {
        text = this.GetComponentInChildren<Text>();
        startingColor = text.color;
        startingSize = text.fontSize;

    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        text.color = hoverColor;
        text.fontSize = textSize;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        text.color = startingColor;
        text.fontSize = startingSize;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        text.color = startingColor;
        text.fontSize = startingSize;
    }
}
