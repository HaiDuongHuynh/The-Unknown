using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaseBroken : MonoBehaviour
{
    public GameObject fakeVase;
    public GameObject brokenVase;
    public GameObject sphereObject;
    public AudioSource potteryBreak;
    public GameObject keyObject;

    void DamageZombie(int DamageAmount)
    {
        Debug.Log("Hit");
        StartCoroutine(BreakVase());
    }

    IEnumerator BreakVase()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        potteryBreak.Play();
        keyObject.SetActive(true);
        fakeVase.SetActive(false);
        brokenVase.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        sphereObject.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        sphereObject.SetActive(false);
    }
}
