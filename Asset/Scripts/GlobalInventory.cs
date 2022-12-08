using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalInventory : MonoBehaviour
{
    public static bool key = false;
    public static bool key1 = false;
    public static bool key2 = false;
    public static bool key3 = false;
    public static bool key4 = false;
    public bool internalDoorKey;

    void Update()
    {
        internalDoorKey = key; 
    }
}
