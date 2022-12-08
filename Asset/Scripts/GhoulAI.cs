using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GhoulAI : MonoBehaviour
{
    public GameObject GhoulDes;
    NavMeshAgent Ghoul;
    public GameObject GhoulEnemy;
    public static bool isAware;
    public bool internalAware;
    public bool attackTrigger = false;
    public bool isAttack = false;
    public AudioSource hurtSound;
    public GameObject theFlash;
    void Start()
    {
        Ghoul = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        internalAware = isAware;
        if (isAware == false)
        {
            GhoulEnemy.GetComponent<Animation>().Play("Idle");
            Ghoul.speed = 0;
        }
        else
        {
            if (attackTrigger == false)
            {
                Ghoul.speed = 15;
                GhoulEnemy.GetComponent<Animation>().Play("Run");
                Ghoul.SetDestination(GhoulDes.transform.position);
            }
            if(attackTrigger == true && isAttack == false)
            {
                Ghoul.speed = 0;
                GhoulEnemy.GetComponent<Animation>().Play("Attack1");
                StartCoroutine(InflictDamage());
            }
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
        yield return new WaitForSeconds(1f);
        GlobalHealth.currentHealth -= 10;
        hurtSound.Play();
        theFlash.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        theFlash.SetActive(false);
        

        yield return new WaitForSeconds(0.9f);
        isAttack = false;
    }

}
