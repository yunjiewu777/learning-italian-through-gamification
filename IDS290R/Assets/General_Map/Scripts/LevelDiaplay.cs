using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelDiaplay : MonoBehaviour
{
    public Level level;
    public MissionDatabase missionDataBase;
    public int currentL;
    public Button bu;

 

    private void Awake()
    {
        bu = GetComponent<Button>();
        bu.interactable = false;
    }


    private void OnEnable()
    {
        if (currentL <= level.difficultyLevel)
            bu.interactable = true;
        else if( SaveManager.GetInstance().minigameA.score[currentL-2] >= missionDataBase.missionTasks[0].needGoods.goodsCount[currentL - 2] &&
            SaveManager.GetInstance().minigameM.score[currentL - 2] >= missionDataBase.missionTasks[1].needGoods.goodsCount[currentL - 2] &&
            SaveManager.GetInstance().minigameT.score[currentL - 2] >= missionDataBase.missionTasks[2].needGoods.goodsCount[currentL - 2])
            bu.interactable = true;
    }
}
