using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectionList : MonoBehaviour
{
    public TMP_Text[] partTexts;
    private bool[] collectedParts;
    public Canvas canvas;
    public GameObject listUI; 
    public GameObject compassUI; 
    private bool isShowing = false;
    private int displayState = 0;

    private void Start()
    {
        collectedParts = new bool[partTexts.Length];
        for (int i = 0; i < partTexts.Length; i++)
        {
            collectedParts[i] = false;
        }
        UpdateUI();
    }

    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Tab))
        {
            isShowing = !isShowing;
            UpdateUI();
        }
        if (Input.GetKeyDown(KeyCode.Q)) 
        {
            if (isShowing) 
            {
                displayState = (displayState + 1) % 2;
                UpdateUI();
            }
        }
    }
    public void CollectPart(int partIndex)
    {
        if (partIndex >= 0 && partIndex < collectedParts.Length)
        {
            collectedParts[partIndex] = true;
            partTexts[partIndex].color = Color.red;
            partTexts[partIndex].fontStyle = FontStyles.Strikethrough;
        }
    }

    void UpdateUI()
    {
        canvas.gameObject.SetActive(isShowing); 
        listUI.SetActive(displayState == 0 && isShowing); 
        compassUI.SetActive(displayState == 1 && isShowing); 
    }


}
