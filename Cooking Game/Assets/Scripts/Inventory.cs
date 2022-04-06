using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{   
    //State variables
    [SerializeField] public bool[] isFull;
    //Put player slots here
    [SerializeField] public GameObject[] slots;

}
