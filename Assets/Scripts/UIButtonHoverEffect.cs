using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class UIButtonHoverEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    [Header("UI Elements")]
    public Image outline; // assign if Outline is an Image
    public TextMeshProUGUI buttonText;
    public GameObject pointer; // arrow icon

    [Header("Colors")]
    public Color normalOutlineColor = Color.gray;
    public Color hoverOutlineColor = Color.yellow;
    public Color pressedOutlineColor = Color.yellow;

    public Color normalTextColor = Color.gray;
    public Color hoverTextColor = Color.yellow;
    public Color pressedTextColor = Color.yellow;


    // Start is called before the first frame update
    void Start()
    {
        if (outline != null)
            outline.color = normalOutlineColor;

        if (buttonText != null)
            buttonText.color = normalTextColor;

        if (pointer != null)
            pointer.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (outline != null)
            outline.color = hoverOutlineColor;

        if (buttonText != null)
            buttonText.color = hoverTextColor;

        if (pointer != null)
            pointer.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (outline != null)
            outline.color = normalOutlineColor;

        if (buttonText != null)
            buttonText.color = normalTextColor;

        if (pointer != null)
            pointer.SetActive(false);
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
