using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Question : MonoBehaviour
{
    public Text questionText;
    string[] questionPool = {"Question 1", "Question 2", "Question 3", "Question 4", "Question 5"};
    public int questionNum = 0;
    void Start()
    {
        if(questionText != null){
            questionText.text = "Question: " + questionPool[(int)questionNum];
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}

