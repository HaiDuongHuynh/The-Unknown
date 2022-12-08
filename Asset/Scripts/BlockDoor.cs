using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDoor : MonoBehaviour
{
    public GameObject Plank1;
    public GameObject Plank2;
    public GameObject Plank3;
    public GameObject Plank4;
    public GameObject DoorTrigger;

    // Update is called once per frame
    void Update()
    {
        if(Plank1.activeSelf == false && 
            Plank2.activeSelf == false && 
            Plank3.activeSelf == false && 
            Plank4.activeSelf == false)
        {
            DoorTrigger.SetActive(true);
        }
    }
}
