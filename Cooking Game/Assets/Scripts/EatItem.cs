using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EatItem : MonoBehaviour
{
    public void Use()
    {
        GameObject.Destroy(gameObject);
    }
}
