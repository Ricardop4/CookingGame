using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    private Inventory inventory;
    [SerializeField] GameObject itemButton;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    public async void OnTriggerEnter2D(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            for(int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    //Item can be added
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
