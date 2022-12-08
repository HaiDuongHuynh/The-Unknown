using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireShotTutorial : MonoBehaviour
{
    public GameObject Player;
    public GameObject TheGun;
    public GameObject MuzzleFlash;
    public AudioSource GunFire;
    public GameObject GunLight;
    public bool IsFiring = false;
    public float TargetDistance;
    public int DamageAmount = 5;

    // Update is called once per frame
    void Update()
    {
        //TargetDistance = Shot.distance;
        if (Input.GetButtonDown("Fire1") && GlobalAmmo.ammoCount > 0)
        {
            if (IsFiring == false)
            {
                GlobalAmmo.ammoCount -= 1;
                StartCoroutine(FiringPistol());
            }
        }

    }

    IEnumerator FiringPistol()
    {
        RaycastHit Shot;
        IsFiring = true;
        if (Physics.Raycast(Player.transform.position, Player.transform.TransformDirection(Vector3.forward), out Shot))
        {
            TargetDistance = Shot.distance;
            ZombieDeathTutorial zombieDeath = Shot.transform.GetComponent<ZombieDeathTutorial>();
            if (zombieDeath != null)
            {
                zombieDeath.DamageZombie(DamageAmount);
            }
            //Shot.transform.SendMessage("DamageZombie", DamageAmount, SendMessageOptions.DontRequireReceiver);
            //Debug.DrawRay(transform.position, transform.forward, Color.cyan);
        }
        TheGun.GetComponent<Animation>().Play("PistolShot");
        MuzzleFlash.SetActive(true);
        GunLight.SetActive(true);
        MuzzleFlash.GetComponent<Animation>().Play("MuzzleAnim");

        GunFire.Play();
        yield return new WaitForSeconds(0.2f);
        GunLight.SetActive(false);
        IsFiring = false;
    }
}
