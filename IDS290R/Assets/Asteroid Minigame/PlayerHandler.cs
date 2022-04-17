using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHandler : MonoBehaviour
{
    public int health = 1;
    public float invulnPeriod = 0;
    float invulnTimer = 0;
    int correctLayer;

    public GameObject end;
    public Text dieText;
    public GameObject die;

    void Start() {
        correctLayer = gameObject.layer;
    }
    void OnTriggerEnter2D(){
        Debug.Log("Trigger!");
            health--;
            invulnTimer = invulnPeriod;
            gameObject.layer = 8;

    }

    void Update() {

        invulnTimer -= Time.deltaTime;
        if(invulnTimer <= 0){
            gameObject.layer = correctLayer;
        }    

        if(health <= 0){
            Die();
        }

    }

    void Die(){
        dieText.text = "Opps, you are hit by an asteroid.";
        GameObject[] stars = GameObject.FindGameObjectsWithTag("star");

        foreach (GameObject a in stars)
        {
            Destroy(a);
        }
        GameObject[] beams = GameObject.FindGameObjectsWithTag("beam");
        foreach (GameObject a in beams)
        {
            Destroy(a);
        }
        QuestionManager.GetInstance().ExitDialogueMode();
        end.SetActive(false);
        die.SetActive(true);     
        Destroy(gameObject);
    }
}
