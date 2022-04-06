using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EatItem : MonoBehaviour
{   
    //State variables
    [SerializeField] int foodPoints = 15;
    //Cached references
    public void Use()
    {
        //Simply adds to score and destroys gameObject
        GameObject.FindGameObjectWithTag("score").GetComponent<Score>().AddToScore(foodPoints);
        EatSFX();
        GameObject.Destroy(gameObject);
    }

    private void EatSFX()
    {
        GameObject.FindGameObjectWithTag("sound").GetComponent<SoundManager>().PlayEatSound();
    }
}
