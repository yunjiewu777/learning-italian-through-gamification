using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuAsteroid : MonoBehaviour
{
    public void ExitButton() {
        // Application.Quit;
        // Debug.Log("Game closed");
        SceneManager.LoadScene("MainMenu");
    }

    public void StartGame(){
        SceneManager.LoadScene("Asteroid");
    }
}
