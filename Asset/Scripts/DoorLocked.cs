using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorLocked : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject TheDoor;
    public AudioSource CreakSound;
    public GameObject ExtraCross;
    public AudioSource DoorLock;

    void Update()
    {
        TheDistance = RayCast.DistanceFromTarget;

    }

    void OnMouseOver()
    {
        if (TheDistance <= 5)
        {
            ExtraCross.SetActive(true);
            ActionText.GetComponent<Text>().text = "Open Door";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);

        }
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 5)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                StartCoroutine(DoorReset());
                //TheDoor.GetComponent<Animation>().Play("doorWing2");
                //CreakSound.Play();

                
            }
        }
    }

    void OnMouseExit()
    {
        ExtraCross.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);

    }

    IEnumerator DoorReset()
    {
        if (GlobalInventory.key == false)
        {
            DoorLock.Play();
            yield return new WaitForSeconds(2);
            this.GetComponent<BoxCollider>().enabled = true;
        }
        else
        {
            TheDoor.GetComponent<Animation>().Play("doorWing3");
            CreakSound.Play();
            this.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
