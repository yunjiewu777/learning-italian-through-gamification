using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public string sceneToLoad;
    public VectorValue plyaerStorage;
    public Text score;
    public Level level;
    public Text scoreText;
    public Task minigame;
    public int gameID;
    public string sceneToSave;

    // Update is called once per frame
    void OnEnable()
    {
        scoreText.text = score.text;
        if (int.Parse(score.text) > minigame.score[level.difficultyLevel - 1])
        {
            minigame.score[level.difficultyLevel - 1] = int.Parse(score.text);
            SaveManager.GetInstance().Save();
        }
    }

    public void StartOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void Exit()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneToLoad);
    }

}
