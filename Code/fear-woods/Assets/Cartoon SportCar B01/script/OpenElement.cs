using UnityEngine;
using System.Collections;

public class OpenElement : MonoBehaviour {

	 private Animator Opening;
    public KeyCode keyboard;
    
    void Start () {
        Opening = GetComponent<Animator>();
        // Set the initial state to open
        Opening.SetInteger("EtatAnim", 1);
    }
    
    void Update () {
        // You may remove this condition if you want the element to always stay open
        if (Input.GetKeyDown(keyboard)) {
            // This block ensures that the element stays open
            if (Opening.GetInteger("EtatAnim") != 1) {
                Opening.SetInteger("EtatAnim", 1);
            }
        }
    }
}
