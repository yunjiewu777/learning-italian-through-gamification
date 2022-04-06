using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuAsteroid : MonoBehaviour
{
    public Vector2 playerPosition;
    public VectorValue plyaerStorage;
    public void ExitButton() {
        // Application.Quit;
        // Debug.Log("Game closed");
        plyaerStorage.initialValue = playerPosition;
        SceneManager.LoadScene("House3");
    }

    public void StartGame(){
        SceneManager.LoadScene("Asteroid");
    }
}
