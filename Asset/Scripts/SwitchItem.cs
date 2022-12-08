using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchItem : MonoBehaviour
{
    public GameObject Pistol;
    public GameObject Crowbar;
    public GameObject FakePistol;
    public GameObject FakeCrowbar;
    void Update()
    {
        if (Input.GetButtonDown("Weapon1") && FakePistol.GetComponent<BoxCollider>().enabled == false)
        {
            Crowbar.SetActive(false);
            Pistol.SetActive(true);           
        }
        if(Input.GetButtonDown("Weapon2") && FakeCrowbar.GetComponent<BoxCollider>().enabled == false)
        {
            Pistol.SetActive(false);
            Crowbar.SetActive(true);
        }
    }
}
