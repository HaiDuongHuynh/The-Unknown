using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalmGhoul : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        GhoulAI.isAware = false;
    }
}
