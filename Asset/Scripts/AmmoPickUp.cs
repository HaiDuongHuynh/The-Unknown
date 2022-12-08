using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoPickUp : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    //public GameObject FakePistol;
    public GameObject AmmoBox;
    //public GameObject GuideArrow;
    public GameObject ExtraCross;
    //public GameObject TheJumpTrigger;
    void Update()
    {
        TheDistance = RayCast.DistanceFromTarget;

    }

    void OnMouseOver()
    {
        if (TheDistance <= 5)
        {
            ExtraCross.SetActive(true);
            ActionText.GetComponent<Text>().text = "Pick up ammo";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);

        }
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 5)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                GlobalAmmo.ammoCount += 8;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);

                AmmoBox.SetActive(false);
                
                //GuideArrow.SetActive(false);
                ExtraCross.SetActive(false);
                //TheJumpTrigger.SetActive(true);
            }
        }
    }

    void OnMouseExit()
    {
        ExtraCross.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);

    }
    
}
