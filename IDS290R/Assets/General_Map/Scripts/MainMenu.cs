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
        plyaerStorage.initialValue = playerPosition;
        SceneManager.LoadScene("Town");

    }
}
