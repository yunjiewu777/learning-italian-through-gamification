using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CategoryBtnScript : MonoBehaviour
{
    [SerializeField] private Text categoryTitleText;
    [SerializeField] private Text scoreText;
    [SerializeField] private Button btn;

    public Button Btn { get => btn; }

    public void SetButton(string title, int totalQuestion)
    {
        if (title == "Pronunciation")
            btn.interactable = false;
        categoryTitleText.text = title;
        scoreText.text = PlayerPrefs.GetInt(title+ (SaveManager.GetInstance().level.difficultyLevel).ToString(), 0) + "/" + totalQuestion; //we get the score save for this category
    }

}
