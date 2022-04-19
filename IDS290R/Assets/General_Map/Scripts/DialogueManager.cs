using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private GameObject levelPanel;
    [Header("Dialouge UI")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private Text dialogueText;
    [SerializeField] private Text displayNameText;
    [SerializeField] private string sceneToLoad;
    [SerializeField] private string level;
    [SerializeField] private string culture;

    private bool loading = false;

    [Header("Choice UI")]
    [SerializeField] private GameObject[] choices;
    private Text[] choicesText;

    private const string SPEAKER_TAG = "speaker";
    private const string SCENE = "scene";
    private const string LEVEL = "level";
    private const string CULTURE = "culture";


    private Story currentStory;

    private static DialogueManager instance;
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
        if (currentStory.currentChoices.Count == 0 && Input.GetKeyDown(KeyCode.Space) && !loading)
            ContinueStory();
        if(sceneToLoad != "")
        {
            StartCoroutine(DelaySceneLoad());
        }
        if (level == "change")
        {
            StartCoroutine(ChangeLevel());
        }
        if (culture == "true")
        {
            dialogueText.rectTransform.sizeDelta = new Vector2(225, 200);
        }
        
    }

    public void Click()
    {
        if (!dialogueIsPlaying)
            return;
        if (currentStory.currentChoices.Count == 0 && !loading)
            ContinueStory();
        if (sceneToLoad != "")
        {
            StartCoroutine(DelaySceneLoad());
        }
        if (level == "change")
        {
            StartCoroutine(ChangeLevel());
        }
    }

    IEnumerator DelaySceneLoad()
    {
        loading = true;
        yield return new WaitForSeconds(0.5f); // Wait 1 seconds
        ExitDialogueMode();
        SceneManager.LoadScene(sceneToLoad); // Change to the ID or Name of the scene to load
    }


    IEnumerator ChangeLevel()
    {
        yield return new WaitForSeconds(0.3f); // Wait 1 seconds
        ExitDialogueMode();
        levelPanel.SetActive(true);
    }


    public static DialogueManager GetInstance()
    {
        return instance;        
    }

    private void Start()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);

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
            if (splitTags.Length != 2) 
            {
               
            }
            string tagKey = splitTags[0].Trim();
            string tagValue = splitTags[1].Trim();

            switch (tagKey)
            {
                case SPEAKER_TAG:
                    displayNameText.text = tagValue;
                    break;
                case SCENE:
                    sceneToLoad = tagValue;
                    break;
                case LEVEL:
                    level = tagValue;
                    break;
                case CULTURE:
                    culture = tagValue;
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

        displayNameText.text = "???";
        sceneToLoad = "";
        level = "";
        culture = "";

        ContinueStory();
    }

    private void ExitDialogueMode()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        dialogueText.rectTransform.sizeDelta = new Vector2(225, 95);
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


    /*
    private IEnumerator SelectFirstChoice()
    {
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(choices[0].gameObject);
    }
    */

    public void MakeChoice(int choiceIndex) 
    {
        currentStory.ChooseChoiceIndex(choiceIndex);
        ContinueStory();
    }

}
