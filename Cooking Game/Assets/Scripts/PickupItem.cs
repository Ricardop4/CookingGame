using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{   
    //State variables
    [SerializeField] public GameObject itemButton;
    [SerializeField] int i;

    //Cached references

    public Inventory inventory;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    //When the player comes in contact with the item,
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {   
            for(int i = 0; i < inventory.slots.Length; i++)//Cycles through the inventory slots
            {
                if (inventory.isFull[i] == false)
                {
                    //Item can be added in the inventory slot that is empty
                    inventory.isFull[i] = true;
                    PickUpSFX();
                    Instantiate(itemButton, inventory.slots[i].transform, false);//false for world coordinates
                    Destroy(gameObject);//Gets rid of the item
                    break;//Prevents further cloning of items
                }
            }

        }
    }
    private void PickUpSFX()
    {
        GameObject.FindGameObjectWithTag("sound").GetComponent<SoundManager>().PlayPickUpSound();
    }
}
