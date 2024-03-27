using UnityEngine;
using System.Collections;

public class on_off_light : MonoBehaviour
{

	 public Light[] lights;

    void Start()
    {
        // Turn on all lights when the script starts
        foreach (Light light in lights)
        {
            light.enabled = true;
        }
    }
}

