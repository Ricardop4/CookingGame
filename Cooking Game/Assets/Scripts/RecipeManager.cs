using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeManager : MonoBehaviour
{   
    //State variables

    [SerializeField] AudioClip cookSound;
    [SerializeField] List<GameObject> RecipeResults;//List of random results
    [SerializeField] bool canCook;//Enables player to cook or not
    [SerializeField] int numberOfResults = 0;//Allows code to choose random with a maximum number
    [SerializeField] List<GameObject> slots;

    int itemsInInventory = 0;

    //cached references
    GameObject item;
    private Inventory inventory;
    private Transform player;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        itemsInInventory = 0;//Looks for inventory slots and figures out if they are full
        for(int i = 0; i < inventory.slots.Length; i++)
        {
            if (inventory.isFull[i] == true)
            {
                itemsInInventory++;//Counts how many items the player currently has
            }
        }
        if(itemsInInventory >= 3)
        {   
            //Debug.Log("You can cook now!");
            canCook = true;
        } else {
            //Debug.Log("Collect more food items first!");
            canCook = false;
        }
    }


    public void CookingTime()
    {
        itemsInInventory = 0;
        if(canCook)
        {
            //Disables canCook
            canCook = false;
            //Finds the players location and sets spawn to near player
            Vector2 playerPos = new Vector2(player.position.x + Random.Range(-1f,1.1f), player.position.y + 2);
            //choose a random game object from list and instantiate near player
            int i = Random.Range(0, numberOfResults);
            Instantiate(RecipeResults[i], playerPos, Quaternion.identity);
            //Debug.Log("I have cooked your food");
            //Destroy all items in inventory
            foreach(GameObject slot in slots)
            {
                slot.GetComponent<Slot>().EmptyInventory();//Find all the slots and empty them or destroy GameObject
            }
            PlayCookingSound();
        }
    }


        private void PlayCookingSound()
        {
            AudioSource.PlayClipAtPoint(cookSound, Camera.main.transform.position);
        }

}
