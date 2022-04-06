using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    //State variables
    [SerializeField] int i;
    //Cached references
    private Inventory inventory;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void Update()
    {
        if (transform.childCount <= 0)
        {
            //Finds out if the inventory is full
            inventory.isFull[i] = false;
        }
    }
    public void DropItem()
    {
        foreach(Transform child in transform)
        {
            //Destroys the button item image and spawns in game
            child.GetComponent<Spawn>().SpawnDroppedItem();
            GameObject.Destroy(child.gameObject);
        }
    }

    public void EmptyInventory()
    {
        foreach(Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);//Destroys item in inventory
        }
    }
}
