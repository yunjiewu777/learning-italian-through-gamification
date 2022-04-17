using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
    public GameObject starA;
    public GameObject starB;
    public GameObject starC;
    public GameObject[] stars;
    public GameObject[] beams;


    public GameObject next;
    public GameObject end;
    public Text result;

    [Header("Dialouge UI")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private Text dialogueText;

    [Header("Choice UI")]
    [SerializeField] private GameObject[] choices;
    private Text[] choicesText;

    private const string ANSWER_TAG = "answer";
    [SerializeField] private string answer;

    private const string LAST_TAG = "last";
    [SerializeField] private string last;


    private Story currentStory;
    private static QuestionManager instance;
    public bool dialogueIsPlaying { get; private set; }


    private void Awake()
    {
        if (instance != null)
            Debug.LogWarning("Found more than one Dialogue Manager in the scene");
        instance = this;
    }

    private void Update()
    {
        if (!dialogueIsPlaying)
            return;        
    }


    public static QuestionManager GetInstance()
    {
        return instance;        
    }

    private void Start()
    {
        dialogueIsPlaying = false;

        choicesText = new Text[choices.Length];
        int index = 0;
        foreach (GameObject choice in choices)
        {
            choicesText[index] = choice.GetComponentInChildren<Text>();
            index++;
        }

    }

    private void HandleTags(List<string> currentTags)
    {
        foreach (string tag in currentTags)
        {
            string[] splitTags = tag.Split(':');
            string tagKey = splitTags[0].Trim();
            string tagValue = splitTags[1].Trim();

            switch (tagKey)
            {

                case ANSWER_TAG:
                    answer = tagValue;
                    break;
                case LAST_TAG:
                    last = tagValue;
                    break;
                default:
                    break;
            }
        }
    
    }

    public void EnterDialogueMode(TextAsset inkJSON)
    {
        currentStory = new Story(inkJSON.text);
        dialogueIsPlaying = true;
        dialoguePanel.SetActive(true);
        stars = GameObject.FindGameObjectsWithTag("star");
        answer = "";
        last = "";

        ContinueStory();
    }

    public void ExitDialogueMode()
    {
        dialogueIsPlaying = false;
        Time.timeScale = 0f;
        dialoguePanel.SetActive(false);
        end.SetActive(true);
        dialogueText.text = "";    

    }


    private void ContinueStory()
    {
        if (currentStory.canContinue)
        {
            dialogueText.text = currentStory.Continue();
            DisplayChoices();
            HandleTags(currentStory.currentTags);
        }
        else
            ExitDialogueMode();
    }

    private void DisplayChoices()
    {
        List<Choice> currentChoices = currentStory.currentChoices;

        if (currentChoices.Count > choices.Length)
            Debug.LogError("More choices were given than the UI can support. Number of choices given:" + currentChoices.Count);

        int index = 0;

        foreach (Choice choice in currentChoices)
        {
            choices[index].gameObject.SetActive(true);
            choicesText[index].text = choice.text;
            index++;
        }

        for (int i = index; i < choices.Length; i++)
            choices[i].gameObject.SetActive(false);

        //StartCoroutine(SelectFirstChoice());
    }

    public void MakeChoice(int choiceIndex) 
    {
        currentStory.ChooseChoiceIndex(choiceIndex);
        Time.timeScale = 0f;

        foreach (GameObject a in stars)
        {
            Destroy(a);
        }


        beams = GameObject.FindGameObjectsWithTag("beam");
        foreach (GameObject a in beams)
        {
            Destroy(a);
        }



        ContinueStory();

        if (answer == "correct")
        {
            result.text = "Good job!";
            FindObjectOfType<Point>().ScoreCount();
        }
        else
        {
            result.text = "Your answer is wrong.";
        }

        next.SetActive(true);
    }

    public void NextQuestion() 
    {
        Instantiate(starA);
        Instantiate(starB);
        Instantiate(starC);
        stars = GameObject.FindGameObjectsWithTag("star");
        Time.timeScale = 1f;
        next.SetActive(false);
        ContinueStory();

        if (last == "yes")
        {
            foreach (GameObject a in stars)
            {
                Destroy(a);
            }
            ContinueStory();
        }
            
    }

}
