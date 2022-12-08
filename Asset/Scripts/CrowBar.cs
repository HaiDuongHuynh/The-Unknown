using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowBar : MonoBehaviour
{
    public GameObject Player;
    public GameObject Crowbar;
    public bool IsSwingging = false;
    public float TargetDistance;
    public int DamageAmount = 20;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (IsSwingging == false)
            {
                StartCoroutine(SwinggingCrowbar());
            }
        }
    }

    IEnumerator SwinggingCrowbar()
    {
        yield return new WaitForSeconds(0.2f);
    }
}
