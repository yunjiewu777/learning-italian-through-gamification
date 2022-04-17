using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public AudioMixer mixer;
    public GameObject pauseMenu;
    public Level level;
    public Text levelDisplay;
    bool isShow;
    public GameObject taskPanel;
    private bool isShowTask;

    public GameObject transPanel;
    private bool isShowTrans;

    public GameObject helpPanel;
    private bool isShowHelp;

    public void Start()
    {
        levelDisplay.text = "You are currently on Level " + level.difficultyLevel.ToString();
        isShow = false;
        isShowTrans = false;
        isShowTask = false;
        isShowHelp = false;
        
    }
    public void Update()
    {
        PauseGame();
        TaskPanel();
        Help();
    }
    public void PlayGame()
    {
        if (System.IO.File.Exists(Application.persistentDataPath + "/" + "SaveTest.dat"))
        {
            SaveManager.GetInstance().Load();
            SceneManager.LoadScene("Town");
        }
            
        else
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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

    void Help()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (!isShowHelp)
            {
                isShowHelp = !isShowHelp;
                helpPanel.SetActive(true);
            }
            else
            {
                isShowHelp = !isShowHelp;
                helpPanel.SetActive(false);
            }
        }
    }

    public void CloseHelp()
    {
        isShowHelp = !isShowHelp;
        helpPanel.SetActive(false);
    }

    public void OpenTextbook()
    {
        Application.OpenURL("http://www.google.com".Trim());
    }

    void TaskPanel()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (!isShowTask)
            {
                isShowTask = !isShowTask;
                taskPanel.SetActive(true);
            }
            else
            {
                isShowTask = !isShowTask;
                taskPanel.SetActive(false);
            }
        }
    }

    public void ShowPause()
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

    public void ShowTrans()
    {
        if (!isShowTrans)
        {
            isShowTrans = !isShowTrans;
            transPanel.SetActive(true);
        }
        else
        {
            isShowTrans = !isShowTrans;
            transPanel.SetActive(false);
        }
    }

    public void ShowTask()
    {
        if (!isShowTask)
        {
            isShowTask = !isShowTask;
            taskPanel.SetActive(true);
        }
        else
        {
            isShowTask = !isShowTask;
            taskPanel.SetActive(false);
        }
    }

    public void ShowHelp()
    {
        if (!isShowHelp)
        {
            isShowHelp = !isShowHelp;
            helpPanel.SetActive(true);
        }
        else
        {
            isShowHelp = !isShowHelp;
            helpPanel.SetActive(false);
        }
    }

    public void Main()
    {
        SaveManager.GetInstance().Save();
        SceneManager.LoadScene(0);
    }



}
