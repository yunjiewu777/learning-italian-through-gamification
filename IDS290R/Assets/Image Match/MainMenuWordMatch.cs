using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuWordMatch : MonoBehaviour
{
    public void BackButton() {
        SceneManager.LoadScene("MainMenu");
    }

    public void StartGame(){
        SceneManager.LoadScene("Word_Match");
    }
}
