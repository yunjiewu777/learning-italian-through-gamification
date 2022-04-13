using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseLevel : MonoBehaviour
{

    public Level level;
    public Vector2 playerPosition;
    public VectorValue plyaerStorage;
    public GameObject levelMenu;

    public GameObject endMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ChangeLevel(int setlevel)
    {
        level.difficultyLevel = setlevel;
        plyaerStorage.initialValue = playerPosition;
        SaveManager.GetInstance().Save();
        SceneManager.LoadScene("BigHouse");

    }

    public void exitLevel()
    {
        levelMenu.SetActive(false);
       
    }


    public void End()
    {
        levelMenu.SetActive(false);
        endMenu.SetActive(true);
    }

    public void Stay()
    {
        endMenu.SetActive(false);
    }

    public void Back()
    {
        SceneManager.LoadScene("EndingScene");
    }
}
