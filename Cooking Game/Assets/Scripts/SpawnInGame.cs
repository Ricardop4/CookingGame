using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInGame : MonoBehaviour
{
    [SerializeField] int items;
    [SerializeField] GameObject item;    
    [SerializeField] float minX;
    [SerializeField] float maxX;
    [SerializeField] float minY;
    [SerializeField] float maxY;


    void Start()
    {
        StartCoroutine(ExampleCoroutine());
    }
    IEnumerator ExampleCoroutine()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(2);
        SpawnItem();
    }

    private void SpawnItem()
    {
        Vector2 newPos = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        Instantiate(item, newPos, Quaternion.identity);
    }
}
