using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class compass : MonoBehaviour
{
    public Transform player;
    Vector3 direction;

    void Update()
    {
        direction.z = player.eulerAngles.y;
        transform.localEulerAngles = direction;
    }
}
