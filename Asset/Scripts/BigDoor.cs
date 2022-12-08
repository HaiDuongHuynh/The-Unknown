using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigDoor : MonoBehaviour
{
    void Update()
    {
        if(PlugginKey1.haveKey1 == true && PlugginKey2.haveKey2 == true &&
            PlugginKey3.haveKey3 == true && PlugginKey4.haveKey4 == true)
        {
            this.GetComponent<Animation>().Play("BigDoorAni");
            PlugginKey1.haveKey1 = false;
        }
    }

}
