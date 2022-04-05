using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeManager : MonoBehaviour
{
    [SerializeField] List<GameObject> RecipeResults;
    [SerializeField] bool canCook;
    [SerializeField] public GameObject[] slots;
    [SerializeField] int numberOfResults = 0;
    GameObject item;

    int itemsInInventory = 0;

    //cached references
    private Inventory inventory;
    private Transform player;



    

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        itemsInInventory = 0;
        for(int i = 0; i < inventory.slots.Length; i++)
        {
            if (inventory.isFull[i] == true)
            {
                itemsInInventory++;
            }
        }
        if(itemsInInventory >= 3)
        {   
            Debug.Log("You can cook now!");
            canCook = true;
        } else {
            Debug.Log("Collect more food items first? maybe? just a suggestion.");
            canCook = false;
        }
    }


    public void CookingTime()
    {
        itemsInInventory = 0;
        if(canCook)
        {
            canCook = false;
            //choose a random game object from list and instantiate near player
            Vector2 playerPos = new Vector2(player.position.x + Random.Range(-1f,1.1f), player.position.y + 2);
            int i = Random.Range(0, numberOfResults);
            Instantiate(RecipeResults[i], playerPos, Quaternion.identity);
            Debug.Log("I have cooked your food");
            //Destroy all items in inventory
            foreach(GameObject slot in slots)
            {
                slot.GetComponent<Slot>().EmptyInventory();
            }
        }
    }

}
