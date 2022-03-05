using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Task minigame;

    public Text nameText;
    public Text scoreText;

    private void Start()
    {
        nameText.text = minigame.taskName;
        scoreText.text = minigame.score.ToString();
    }
}
