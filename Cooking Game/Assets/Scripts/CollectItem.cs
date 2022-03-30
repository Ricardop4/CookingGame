using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{   
    [SerializeField] string itemName;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"{itemName} has been collected");
        Destroy(gameObject);
    }
}
