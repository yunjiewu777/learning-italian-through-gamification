using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Task minigame;
    public MissionDatabase missionDataBase;
    public GameObject finish;
    public Level level;

    public int id;
    private Text des;
    private Text need;

    public bool isFinish;

    private void Awake()
    {
        des = transform.Find("des").GetComponent<Text>();
        need = transform.Find("need").GetComponent<Text>();
    }


    private void OnEnable()
    { 
        des.text = missionDataBase.missionTasks[id].des;

        int currentPoint = minigame.score[level.difficultyLevel - 1];
        need.text = currentPoint.ToString() + "/" + missionDataBase.missionTasks[id].needGoods.goodsCount.ToString();
        if (currentPoint >= missionDataBase.missionTasks[id].needGoods.goodsCount)
        {
            isFinish = true;
        }

        if (isFinish)
            finish.SetActive(true);
        else
            finish.SetActive(false);


    }
}
