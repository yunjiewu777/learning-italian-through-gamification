using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Question : MonoBehaviour
{

    [SerializeField] private List<Question4AsteroidScriptable> quizDataList;

    private int correctAnswerCount = 0;
    //questions data
    private List<QuestionAsteroids> questions;
    //current question data
    private QuestionAsteroids selectedQuetion = new QuestionAsteroids();
    public Text questionText;
    // string[] questionsWeek1 = {"Question 1: Match the correct ending: we worked",
    //                         "Question 2: ",
    //                         "Question 3",
    //                         "Question 4", 
    //                         "Question 5"};
    public int questionNum = 0;
    private Question4AsteroidScriptable dataScriptable;

    public List<Question4AsteroidScriptable> QuizData { get => quizDataList; }
     public void StartGame(int categoryIndex, string category)
    {
        correctAnswerCount = 0;
        //set the questions data
        questions = new List<QuestionAsteroids>();
        dataScriptable = quizDataList[categoryIndex];
        questions.AddRange(dataScriptable.questions);
        //select the question
        SelectQuestion();
    }

    private void SelectQuestion()
    {
        //get the random number
        //int val = UnityEngine.Random.Range(0, questions.Count);
        int val = 0;
        //set the selectedQuetion
        selectedQuetion = questions[val];
        //send the question to quizGameUI
        //quizGameUI.SetQuestion(selectedQuetion);
        questions.RemoveAt(val);
        val++;
    }

    public bool Answer(string selectedOption)
    {
        //set default to false
        bool correct = false;
        //if selected answer is similar to the correctAns
        if (selectedQuetion.correctAns == selectedOption)
        {
            //Yes, Ans is correct
            correctAnswerCount++;
            correct = true;
        }
        if (questions.Count > 0)
            {
                //call SelectQuestion method again after 1s
                Invoke("SelectQuestion", 0.4f);
            }
        //return the value of correct bool
        return correct;
    }
    // void Start()
    // {
    //     if(questionText != null){
    //         questionText.text = "Question: " + questionPool[(int)questionNum];
    //     }
    // }

    // // Update is called once per frame
    // void Update()
    // {
    // }
}


[System.Serializable]
public class QuestionAsteroids
{
    public string questionInfo;         //question text
    public List<string> options;        //options to select
    public string correctAns;           //correct option
}