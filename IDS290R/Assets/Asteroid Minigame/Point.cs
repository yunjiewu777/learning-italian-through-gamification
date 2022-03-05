using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;

    private void Start()
    {
        scoreText.text = score.ToString();
    }

    public void ScoreCount()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public int GetScore()
    {
        return score;
    }

}
