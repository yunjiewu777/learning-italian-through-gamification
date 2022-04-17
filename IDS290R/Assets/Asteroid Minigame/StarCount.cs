using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarCount : MonoBehaviour
{

    public int count;


    public GameObject end;
    public Text dieText;
    public GameObject die;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 3)
        {
            GameObject[] beams = GameObject.FindGameObjectsWithTag("beam");
            foreach (GameObject a in beams)
            {
                Destroy(a);
            }
            dieText.text = "Try to shoot asteroids before they fall.";
            QuestionManager.GetInstance().ExitDialogueMode();
            end.SetActive(false);
            die.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "star")
            count++;
    }


}
