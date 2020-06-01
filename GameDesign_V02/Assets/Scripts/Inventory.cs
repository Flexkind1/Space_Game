using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool[] isFull;
    // Wenn der Inventar-Slot belegt ist, ist "isFull" = True
    public GameObject[] slots; 
}
