using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlugginKey4 : MonoBehaviour
{
    public float TheDistance;
    public static bool haveKey4 = false;
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
        if (TheDistance <= 6 && GlobalInventory.key4 == true)
        {
            ExtraCross.SetActive(true);
            ActionText.GetComponent<Text>().text = "Add Green Key";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);

        }
        else if (TheDistance <= 6)
        {
            ActionText.GetComponent<Text>().text = "Need Green Key";
            ActionText.SetActive(true);
        }
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 6 && GlobalInventory.key4 == true)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                Key.SetActive(true);
                haveKey4 = true;
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
