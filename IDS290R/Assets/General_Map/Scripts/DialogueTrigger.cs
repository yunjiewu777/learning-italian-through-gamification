using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    public string speaker;
    public Level level;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;
    [SerializeField] private TextAsset inkJSONTrans;

    private bool playerInRange;

    private void Awake()
    {
        if (speaker == "D" | speaker == "L")
        {
            inkJSON = Resources.Load<TextAsset>("Dialogue/1/" + speaker + "_i");
            inkJSONTrans = Resources.Load<TextAsset>("Dialogue/1/" + speaker + "_e");
        }
        else 
        {
            inkJSON = Resources.Load<TextAsset>("Dialogue/" + level.difficultyLevel + "/" + speaker + "_i");
            inkJSONTrans = Resources.Load<TextAsset>("Dialogue/" + level.difficultyLevel + "/" + speaker + "_e");
        }

        playerInRange = false;
        visualCue.SetActive(false);
    }

    private void Update()
    {
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying)
        {
            visualCue.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
                TranslationManager.GetInstance().EnterDialogueMode(inkJSONTrans);
            }

        }
            
        else
            visualCue.SetActive(false);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            playerInRange = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            playerInRange = false;
        
    }



}
