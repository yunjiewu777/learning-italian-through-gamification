using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectTracker : MonoBehaviour
{
    public List<GameObject> MyGameObjects = new List<GameObject>();
    public GameObject levelCompleteUI;
    int counter = 0;
    // Update is called once per frame

    void Start(){
        if(levelCompleteUI.activeSelf){
             MyGameObjects[counter].SetActive(false);
             counter++;
             MyGameObjects[counter].SetActive(false);
             counter++;
             MyGameObjects[counter].SetActive(true);
             counter++;
             MyGameObjects[counter].SetActive(true);
        } 
    }
    void Update()
    {

    }

}
