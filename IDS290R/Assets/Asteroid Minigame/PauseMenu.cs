using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public string sceneToLoad;
    public VectorValue plyaerStorage;
    public int score;
    public Level level;
    public Text scoreText;
    public Task minigame;
    public int gameID;
    public string sceneToSave;

    // Update is called once per frame
    void Start()
    {
        score = FindObjectOfType<Point>().GetScore();
        scoreText.text = score.ToString();
    }

    public void StartOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void Exit()
    {
        if (score > minigame.score[level.difficultyLevel-1])
        {
            minigame.score[level.difficultyLevel-1] = score;
            SaveManager.GetInstance().Save();
        }
        SceneManager.LoadScene(sceneToLoad);
    }
}
