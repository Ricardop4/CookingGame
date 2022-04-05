using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] int foodPoints = 83;
    [SerializeField] TextMeshProUGUI scoreText;


    // state variables
    [SerializeField] int currentScore = 0;

    private void Start()
    {
        scoreText.text = currentScore.ToString();
    }

    public void AddToScore()
    {
        currentScore += foodPoints;
        scoreText.text = currentScore.ToString();
    }

}
