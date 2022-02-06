using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public AudioMixer mixer;
    public GameObject pauseMenu;
    bool isShow;
    public void Start()
    {
        isShow = false;
    }
    public void Update()
    {
        PauseGame();
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void SetVolume(float value)
    {
        mixer.SetFloat("MainVolume",value);
    }

    void PauseGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isShow)
            {
                isShow = !isShow;
                pauseMenu.SetActive(true);
                Time.timeScale = 0f;
            }
            else
            {
                isShow = !isShow;
                pauseMenu.SetActive(false);
                Time.timeScale = 1f;
            }
        }
    }

    public void Main()
    {
        SceneManager.LoadScene(0);
    }
}
