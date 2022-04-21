using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuQuiztalian : MonoBehaviour
{
    public Vector2 playerPosition;
    public VectorValue plyaerStorage;
    public void BackButton(){
        plyaerStorage.initialValue = playerPosition;
        SceneManager.LoadScene("House1");
    }
    
    public void StartGame(){
        SceneManager.LoadScene("QuizGame");
    }
}
