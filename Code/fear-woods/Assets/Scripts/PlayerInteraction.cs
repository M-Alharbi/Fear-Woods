using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInteraction : MonoBehaviour
{
    public float interactionDistance = 3.0f;
    public TMP_Text CollectibleText;

    private FlashlightControl flashlightControl;
    
    
    private void Start()
    {

        flashlightControl = GetComponentInChildren<FlashlightControl>();
    }
 
    void Update()
    {
        bool isPlayerNear = false;

        string interactableType = "";

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, interactionDistance))
        {
            if (hit.collider.CompareTag("Collectible"))
            {
                isPlayerNear = true;
                
                interactableType = "Collectible";
            }
            else if (hit.collider.CompareTag("Battery")) 
            {
                isPlayerNear = true;
                
                interactableType = "Battery";
            }
        }

        
        if (isPlayerNear)
        {
            CollectibleText.gameObject.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                if (interactableType == "Collectible")
                {
                    hit.collider.GetComponent<Collectible>().Collect();
                }
                else if (interactableType == "Battery")
                {
                    flashlightControl.RefillBattery(25f); 
                    Destroy(hit.collider.gameObject); 
                }
            }
        }
        else
        {
            CollectibleText.gameObject.SetActive(false);
        }
    

    }
}
