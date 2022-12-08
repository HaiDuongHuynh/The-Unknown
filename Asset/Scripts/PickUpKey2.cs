using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpKey2 : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject Key;
    public GameObject KeyUI;

    //public GameObject GuideArrow;
    public GameObject ExtraCross;
    //public GameObject TheJumpTrigger;
    void Update()
    {
        TheDistance = RayCast.DistanceFromTarget;

    }

    void OnMouseOver()
    {
        if (TheDistance <= 6)
        {
            ExtraCross.SetActive(true);
            ActionText.GetComponent<Text>().text = "Pick up yellow key";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);

        }
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 6)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                Key.SetActive(false);
                KeyUI.SetActive(true);
                //GuideArrow.SetActive(false);
                ExtraCross.SetActive(false);
                //TheJumpTrigger.SetActive(true);
                GlobalInventory.key2 = true;
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
