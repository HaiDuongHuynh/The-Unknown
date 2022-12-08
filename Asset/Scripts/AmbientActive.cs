using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientActive : MonoBehaviour
{
    public AudioSource Ambient;
    void OnTriggerEnter(Collider other)
    {
        this.GetComponent<BoxCollider>().enabled = false;
        Ambient.Play();
    }
}
