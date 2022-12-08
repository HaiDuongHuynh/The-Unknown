using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemovePlank : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject Plank;
    public GameObject ExtraCross;
    //public GameObject crowbar;
    // Update is called once per frame
    void Update()
    {
        TheDistance = RayCast.DistanceFromTarget;
    }
    void OnMouseOver()
    {
        if (TheDistance <= 1)
        {
            ExtraCross.SetActive(true);
            ActionText.GetComponent<Text>().text = "Remove Plank";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);

        }
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 1)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                ExtraCross.SetActive(false);
                //Plank.GetComponent<Animation>().Play("FirstDoorAni");
                Plank.SetActive(false);

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
