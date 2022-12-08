using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    public static float DistanceFromTarget;
    public float ToTarget;

    // Update is called once per frame
    void Update()
    {
        RaycastHit Hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit)){
            ToTarget = Hit.distance;
            DistanceFromTarget = ToTarget;
            
        }
    }
}
