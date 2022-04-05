using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInGame : MonoBehaviour
{
    [SerializeField] int numberOfItems;
    [SerializeField] GameObject item;    
    [SerializeField] float minX = -6.5f;
    [SerializeField] float maxX = 6.5f;
    [SerializeField] float minY = -1f;
    [SerializeField] float maxY = 4.5f;


    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("item").Length <= 10)
        {
            SpawnItem();
        }

    }
    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(2);
        SpawnItem();
    }

    private void SpawnItem()
    {
        Vector2 newPos = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        Instantiate(item, newPos, Quaternion.identity);
    }
}
