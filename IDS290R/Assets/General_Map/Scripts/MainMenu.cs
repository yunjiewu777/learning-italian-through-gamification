using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Vector2 playerPosition;
    public VectorValue plyaerStorage;
    public Level setLevel;

    public void Enter()
    {

        if (System.IO.File.Exists(Application.persistentDataPath + "/" + "SaveTest.dat"))
        {
            SaveManager.GetInstance().Load();
            plyaerStorage.initialValue = playerPosition;
            SceneManager.LoadScene("Town");
        }
        else
            SceneManager.LoadScene("Asteroid");
    }

}
