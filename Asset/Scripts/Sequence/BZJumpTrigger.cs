using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BZJumpTrigger : MonoBehaviour
{
    public AudioSource JumpMusic;
    public GameObject TheZombie;
    

    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        TheZombie.SetActive(true);
        StartCoroutine(PlayJumpMusic());
    }

    IEnumerator PlayJumpMusic()
    {
        yield return new WaitForSeconds(0.01f);
        
        JumpMusic.Play();
    }
}
