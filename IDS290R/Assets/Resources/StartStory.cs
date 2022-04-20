using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainStory : MonoBehaviour
{

    public VectorValue plyaerStorage;

    void OnEnable(){
        SceneManager.LoadScene("MainMenu");
    }
}
