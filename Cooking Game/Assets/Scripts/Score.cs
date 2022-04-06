using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    // state variables
    [SerializeField] int currentScore = 0;//Start score at 0

    //Cached references
    [SerializeField] TextMeshProUGUI scoreText;



    private void Start()//Makes the score to 0 and displays as a string
    {
        scoreText.text = currentScore.ToString();
    }

    public void AddToScore(int foodPoints)//Adds to score
    {   
        currentScore += foodPoints;
        scoreText.text = currentScore.ToString();
    }

}
