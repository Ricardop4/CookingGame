using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    [SerializeField] GameObject item;
    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void SpawnDroppedItem()
    {
        Vector2 playerPos = new Vector2(player.position.x + Random.Range(-1f,1.1f), player.position.y + 2);
        Instantiate(item, playerPos, Quaternion.identity);
    }

    public void DestroyUsedItem()
    {
        Destroy(item);
    }
}
