using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveRandomly : MonoBehaviour
{
    public GameObject Zombie;
    NavMeshAgent navMeshAgent;
    NavMeshPath path;
    public float timeForNewPath;
    bool inCoroutine;
    Vector3 target;
    bool validPath;

    
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        path = new NavMeshPath();
    }

    // Update is called once per frame
    void Update()
    {
        if (!inCoroutine)
        {
            StartCoroutine(doSomething());
        }
    }

    Vector3 getNewRandomPosition()
    {
        float x = Random.Range(Zombie.transform.position.x - 10f, Zombie.transform.position.x + 10f);
        float z = Random.Range(Zombie.transform.position.z - 10f, Zombie.transform.position.z + 10f);

        Vector3 pos = new Vector3(x, 1.045f, z);
        return pos;
    }
 
    IEnumerator doSomething()
    {
        inCoroutine = true;
        yield return new WaitForSeconds(timeForNewPath);
        GetNewPath();
        validPath = navMeshAgent.CalculatePath(target, path);
        if (!validPath)
        {
            Debug.Log("Found an invalid path");
        }

        while (!validPath)
        {
            yield return new WaitForSeconds(0.01f);
            GetNewPath();
            validPath = navMeshAgent.CalculatePath(target, path);
        }
        inCoroutine = false;
    }

    void GetNewPath()
    {
       target = getNewRandomPosition();
       navMeshAgent.SetDestination(target);
    }
}
