using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionTrigger : MonoBehaviour
{

    public Level level;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    public GameObject startPanel;

    private void Awake()
    {
        inkJSON = Resources.Load<TextAsset>("Asteroid/" + level.difficultyLevel);
    }

    private void OnEnable()
    {
        Time.timeScale = 0f;
    }


    public void StartGame()
    {
        startPanel.SetActive(false);
        Time.timeScale = 1f;
        QuestionManager.GetInstance().EnterDialogueMode(inkJSON);
    }



}
