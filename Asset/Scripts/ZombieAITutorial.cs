using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAITutorial : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject theEnemy;
    //public Collider zombieVision;
    public float enemySpeed = 0.001f;
    public float enemyChasing = 0.01f;
    public bool attackTrigger = false;
    public bool isAttack = false;
    public AudioSource hurtSound;
    public GameObject theFlash;
    //public bool isAware = false;

    // public float viewDistance = 10f;
    // public float wanderRadius = 7f;


    //public int hurtGen;

    // Update is called once per frame
    void Update()
    {

        
        //theEnemy.GetComponent<MoveRandomly>().enabled = false;
        transform.LookAt(thePlayer.transform);
            if (attackTrigger == false)
            {
                enemySpeed = 0.003f;
                theEnemy.GetComponent<Animation>().Play("Z_Walk1_InPlace 2");
                transform.position = Vector3.MoveTowards(transform.position, thePlayer.transform.position, enemySpeed);

            }
            if (attackTrigger == true && isAttack == false)
            {
                enemySpeed = 0;
                theEnemy.GetComponent<Animation>().Play("Z_Attack 1");
                StartCoroutine(InflictDamage());
            }
        
        
    }


    void OnTriggerEnter(Collider other)
    {
        attackTrigger = true;
    }

    void OnTriggerExit(Collider other)
    {
        attackTrigger = false;
    }
    IEnumerator InflictDamage()
    {
        isAttack = true;
        GlobalHealth.currentHealth -= 5;
        hurtSound.Play();
        theFlash.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        theFlash.SetActive(false);
        yield return new WaitForSeconds(1.1f);

        yield return new WaitForSeconds(0.9f);
        isAttack = false;
    }
}
