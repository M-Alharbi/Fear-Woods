using UnityEngine;
using System.Collections;

public class OpenElement : MonoBehaviour {

	 private Animator Opening;
    public KeyCode keyboard;
    
    void Start () {
        Opening = GetComponent<Animator>();
        
        Opening.SetInteger("EtatAnim", 1);
    }
    
    void Update () {
        
        if (Input.GetKeyDown(keyboard)) {
            
            if (Opening.GetInteger("EtatAnim") != 1) {
                Opening.SetInteger("EtatAnim", 1);
            }
        }
    }
}
