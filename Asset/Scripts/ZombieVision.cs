using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieVision : MonoBehaviour
{
    public GameObject theZombie;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            theZombie.GetComponent<ZombieAI>().SetAware(true);
            //theZombie.GetComponent<MoveRandomly>().enabled = false;
            //theZombie.GetComponent<NavMeshAgent>().enabled = false;
        }
    }
}
