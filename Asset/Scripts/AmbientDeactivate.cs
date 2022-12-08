using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientDeactivate : MonoBehaviour
{
    public AudioSource Ambient;
    public GameObject TriggerAttack;
    void OnTriggerEnter(Collider other)
    {
        this.GetComponent<BoxCollider>().enabled = false;
        Ambient.Stop();
        TriggerAttack.SetActive(true);
    }
}
