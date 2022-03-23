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


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ChangeLevel(int setlevel)
    {
        level.difficultyLevel = setlevel;
        plyaerStorage.initialValue = playerPosition;
        SceneManager.LoadScene("BigHouse");

    }

    public void exitLevel()
    {
        levelMenu.SetActive(false);
       
    }
}
