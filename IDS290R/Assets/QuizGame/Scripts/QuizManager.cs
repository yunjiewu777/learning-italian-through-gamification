using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
#pragma warning disable 649
    //ref to the QuizGameUI script
    [SerializeField] private QuizGameUI quizGameUI;
    //ref to the scriptableobject file
    [SerializeField] private List<QuizDataScriptable> quizDataList;
    [SerializeField] private float timeInSeconds;
#pragma warning restore 649

    private string currentCategory = "";
    private int correctAnswerCount = 0;
    //questions data
    private List<QuestionQuiz> questions;
    //current question data
    private QuestionQuiz selectedQuetion = new QuestionQuiz();
    private int gameScore;
    private int lifesRemaining;
    private float currentTime;
    private QuizDataScriptable dataScriptable;

    private GameStatus gameStatus = GameStatus.NEXT;

    public GameStatus GameStatus { get { return gameStatus; } }

    public List<QuizDataScriptable> QuizData { get => quizDataList; }



    private void Awake()
    {
        QuizData.Add(Resources.Load<QuizDataScriptable>("Quiz/Pro/PronunciationDataWeek"+ (SaveManager.GetInstance().level.difficultyLevel).ToString()));
        QuizData.Add(Resources.Load<QuizDataScriptable>("Quiz/Mis/MiscellaneousWeek" + (SaveManager.GetInstance().level.difficultyLevel).ToString()));
        QuizData.Add(Resources.Load<QuizDataScriptable>("Quiz/Voca/VocabDataWeek" + (SaveManager.GetInstance().level.difficultyLevel).ToString()));

    }





    public void StartGame(int categoryIndex, string category)
    {
        currentCategory = category;
        correctAnswerCount = 0;
        gameScore = 0;
        lifesRemaining = 3;
        currentTime = timeInSeconds;
        //set the questions data
        questions = new List<QuestionQuiz>();
        dataScriptable = quizDataList[categoryIndex];
        questions.AddRange(dataScriptable.questions);
        //select the question
        SelectQuestion();
        gameStatus = GameStatus.PLAYING;
    }

    /// <summary>
    /// Method used to randomly select the question form questions data
    /// </summary>
    private void SelectQuestion()
    {
        //get the random number
        //int val = UnityEngine.Random.Range(0, questions.Count);
        int val = 0;
        //set the selectedQuetion
        selectedQuetion = questions[val];
        //send the question to quizGameUI
        quizGameUI.SetQuestion(selectedQuetion);

        questions.RemoveAt(val);
        val++;
    }

    private void Update()
    {
        if (gameStatus == GameStatus.PLAYING)
        {
            currentTime -= Time.deltaTime;
            SetTime(currentTime);
        }
    }

    void SetTime(float value)
    {
        TimeSpan time = TimeSpan.FromSeconds(currentTime);                       //set the time value
        quizGameUI.TimerText.text = time.ToString("mm':'ss");   //convert time to Time format

        if (currentTime <= 0)
        {
            //Game Over
            GameEnd();
        }
    }

    /// <summary>
    /// Method called to check the answer is correct or not
    /// </summary>
    /// <param name="selectedOption">answer string</param>
    /// <returns></returns>
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
            gameScore += 50;
            quizGameUI.ScoreText.text = "Score:" + gameScore;
        }
        else
        {
            //No, Ans is wrong
            //Reduce Life
            lifesRemaining--;
            quizGameUI.ReduceLife(lifesRemaining);

            if (lifesRemaining == 0)
            {
                GameEnd();
            }
        }

        if (gameStatus == GameStatus.PLAYING)
        {
            if (questions.Count > 0)
            {
                //call SelectQuestion method again after 1s
                Invoke("SelectQuestion", 0.4f);
            }
            else
            {
                GameEnd();
            }
        }
        //return the value of correct bool
        return correct;
    }

    private void GameEnd()
    {
        gameStatus = GameStatus.NEXT;
        quizGameUI.GameOverPanel.SetActive(true);

        //fi you want to save only the highest score then compare the current score with saved score and if more save the new score
        //eg:- if correctAnswerCount > PlayerPrefs.GetInt(currentCategory) then call below line
        //xd
        //Save the score
        PlayerPrefs.SetInt(currentCategory+(SaveManager.GetInstance().level.difficultyLevel).ToString(), correctAnswerCount); //save the score for this category
    }
}

//Datastructure for storeing the quetions data
[System.Serializable]
public class QuestionQuiz
{
    public string questionInfo;         //question text
    public QuestionType questionType;   //type
    public Sprite questionImage;        //image for Image Type
    public AudioClip audioClip;         //audio for audio type
    public UnityEngine.Video.VideoClip videoClip;   //video for video type
    public List<string> options;        //options to select
    public string correctAns;           //correct option
}

[System.Serializable]
public enum QuestionType
{
    TEXT,
    IMAGE,
    AUDIO,
    VIDEO
}

[SerializeField]
public enum GameStatus
{
    PLAYING,
    NEXT
}