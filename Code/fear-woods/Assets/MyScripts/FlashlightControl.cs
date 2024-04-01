using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashlightControl : MonoBehaviour
{
    public GameObject flashlight;
    public Image batteryLevelUI; 
    public bool flashlightOn = false;
    public float batteryLevel = 100f; 
    public float drainRate = 0.5f; 
    void Start()
    {
        flashlight.SetActive(false); 
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
           flashlightOn = !flashlightOn;
            flashlight.SetActive(flashlightOn);
        }
        if (flashlightOn)
        {
            batteryLevel -= drainRate * Time.deltaTime;
            batteryLevelUI.fillAmount = batteryLevel / 100f;
            if (batteryLevel <= 0)
            {
                flashlightOn = false;
                flashlight.SetActive(false);
            }
        }
        
    }

    public void RefillBattery(float amount)
    {
        batteryLevel += amount;
        if (batteryLevel > 100)
        {
            batteryLevel = 100;
        }
    }
}
