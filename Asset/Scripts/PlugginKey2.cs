using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlugginKey2 : MonoBehaviour
{
    public float TheDistance;
    public static bool haveKey2 = false;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    //public GameObject KeyHole;
    public GameObject KeyUI;
    public GameObject Key;

    //public GameObject GuideArrow;
    public GameObject ExtraCross;
    //public GameObject TheJumpTrigger;
    void Update()
    {
        TheDistance = RayCast.DistanceFromTarget;

    }

    void OnMouseOver()
    {
        if (TheDistance <= 6 && GlobalInventory.key2 == true)
        {
            ExtraCross.SetActive(true);
            ActionText.GetComponent<Text>().text = "Add Yellow Key";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);

        }
        else if (TheDistance <= 6)
        {
            ActionText.GetComponent<Text>().text = "Need Yellow Key";
            ActionText.SetActive(true);
        }
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 6 && GlobalInventory.key2 == true)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                Key.SetActive(true);
                haveKey2 = true;
                KeyUI.SetActive(false);
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
