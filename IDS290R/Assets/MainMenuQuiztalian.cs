using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuQuiztalian : MonoBehaviour
{
    public void BackButton(){
        SceneManager.LoadScene("MainMenu");
    }
    
    public void StartGame(){
        SceneManager.LoadScene("QuizGame");
    }
}
