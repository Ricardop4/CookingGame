using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInGame : MonoBehaviour
{   
    //State variables
    [SerializeField] List<GameObject> spawnableItems;  
    [SerializeField] int numberOfItems;  
    [SerializeField] float minX = -6.5f;
    [SerializeField] float maxX = 6.5f;
    [SerializeField] float minY = -1f;
    [SerializeField] float maxY = 4.5f;

    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("item").Length <= 9)
        {
            SpawnItem();
        }
    }

    private void SpawnItem()
    {
        int i = Random.Range(0, numberOfItems);//Chooses which items to spawn
        Vector2 newPos = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));//Sets coordinates of where to spawn
        Instantiate(spawnableItems[i], newPos, Quaternion.identity);//Spawns item
    }
}
