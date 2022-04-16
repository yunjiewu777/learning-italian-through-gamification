using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuWordMatch : MonoBehaviour
{
    public Vector2 playerPosition;
    public VectorValue plyaerStorage;
    public void BackButton() {
        plyaerStorage.initialValue = playerPosition;
        SceneManager.LoadScene("House3");
    }

    public void StartGame(){
        SceneManager.LoadScene("Word_Match");
    }
}
