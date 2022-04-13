using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class MainMenu : MonoBehaviour
{
    public Vector2 playerPosition;
    public VectorValue plyaerStorage;
    public Level setLevel;

    public GameObject warning1;
    public GameObject warning2;

    public void Enter()
    {

        if (System.IO.File.Exists(Application.persistentDataPath + "/" + "SaveTest.dat"))
        {
            warning1.SetActive(true);
        }
        else
            startNewGame();
    }


    public void Load()
    {

        if (System.IO.File.Exists(Application.persistentDataPath + "/" + "SaveTest.dat"))
        {
            plyaerStorage.initialValue = playerPosition;
            SaveManager.GetInstance().Load();
            SceneManager.LoadScene("Town");
        }
        else
        {
            warning2.SetActive(true);
        }
            
    }

    public void startNewGame()
    {
        File.Delete(Application.persistentDataPath + "/" + "SaveTest.dat");
        plyaerStorage.initialValue = playerPosition;
        SaveManager.GetInstance().level.difficultyLevel = 1;
        SaveManager.GetInstance().minigameA.score = new int[5];
        SaveManager.GetInstance().minigameM.score = new int[5];
        SaveManager.GetInstance().minigameT.score = new int[5];
        SceneManager.LoadScene("Intro_Story");
    }

    public void closeWarning2()
    {
        warning2.SetActive(false);
    }

    public void closeWarning1()
    {
        warning1.SetActive(false);
    }


    public void Intro()
    {
        SceneManager.LoadScene("Intro_Story", LoadSceneMode.Single);
    }

    public void Contributor()
    {
        SceneManager.LoadScene("", LoadSceneMode.Single);
    }

}
