using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bearDetection : MonoBehaviour
{
    static public bool detectsPlayer = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "PlayerCapsule")
        {
            detectsPlayer = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        detectsPlayer = false;
    }
}

