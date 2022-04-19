using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuQuizGame : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pauseMenuUI;
    public float GameIsPaused;
    public bool pauseShown = false;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if (pauseShown)
            {
                Resume();
            }
            else
            {
                GameIsPaused = Time.timeScale;
                Pause();
            }
        }
    }

    public void Resume ()
    {
        pauseShown = !pauseShown;
        pauseMenuUI.SetActive(false);
        Time.timeScale = GameIsPaused;
    }

    void Pause ()
    {
        pauseShown = !pauseShown;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void LoadMenu(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("QuizGame_MainMenu");
    }

    public void Restart()
    {
        SceneManager.LoadScene("QuizGame");
    }
}
