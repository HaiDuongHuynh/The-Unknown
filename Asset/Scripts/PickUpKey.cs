using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpKey : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject theKey;
    
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
            ActionText.GetComponent<Text>().text = "Pick up key";
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
                theKey.SetActive(false);

                //GuideArrow.SetActive(false);
                ExtraCross.SetActive(false);
                //TheJumpTrigger.SetActive(true);
                GlobalInventory.key = true;

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
