using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public string sceneToLoad;
    public Vector2 playerPosition;
    public VectorValue plyaerStorage;
    public int score;
    public Task minigame;
    public Text scoreText;

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
        plyaerStorage.initialValue = playerPosition;
        if (score > minigame.score[0])
            minigame.score[0] = score;
        SceneManager.LoadScene(sceneToLoad);
    }
}
