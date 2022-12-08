using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGhoul : MonoBehaviour
{
    public AudioSource JumpMusic;
    public GameObject Block;
    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        Block.SetActive(true);
        JumpMusic.Play();
        GhoulAI.isAware = true;
    }
}
