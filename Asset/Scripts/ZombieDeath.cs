using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieDeath : MonoBehaviour
{
    public int EnemyHealth = 20;
    public GameObject TheEnemy;
    public int StatusCheck;
    public AudioSource JumpMusic;
    public AudioSource AmbMusic;
    
    //public AudioSource JumpScareMusic;

    public void DamageZombie(int DamageAmount)
    {
        Debug.Log("Hit");
        EnemyHealth -= DamageAmount;
    }


    void Update()
    {
       if(EnemyHealth <= 0 && StatusCheck == 0)
        {
            StatusCheck = 2;
            this.GetComponent<ZombieAI>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            this.GetComponent<MoveRandomly>().enabled = false;
            this.GetComponent<NavMeshAgent>().enabled = false;

            TheEnemy.GetComponent<Animation>().Stop("Z_Walk1_InPlace 2");
            TheEnemy.GetComponent<Animation>().Play("Z_FallingBack 2");
            JumpMusic.Stop();
            StartCoroutine(Disappear());
            //AmbMusic.Play();
        } 
    }

    IEnumerator Disappear()
    {
        yield return new WaitForSeconds(10.0f);
        TheEnemy.SetActive(false);
    }
}
