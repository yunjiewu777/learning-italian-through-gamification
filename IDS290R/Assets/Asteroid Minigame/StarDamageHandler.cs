using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarDamageHandler : MonoBehaviour
{
    public int health = 1;
    public float invulnPeriod = 0;
    float invulnTimer = 0;
    int correctLayer;
    public int choice;

    void Start() {
        correctLayer = gameObject.layer;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "beam")
        {
            Debug.Log("Trigger!");
            health--;
            invulnTimer = invulnPeriod;
            gameObject.layer = 8;
        }
        else if (collision.tag == "boarder")
        {
            Destroy(gameObject);
        }
       

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
        // FindObjectOfType<Point>().ScoreCount();
        QuestionManager.GetInstance().MakeChoice(choice);
        Destroy(gameObject);
       // end.SetActive(true);
    }


}
