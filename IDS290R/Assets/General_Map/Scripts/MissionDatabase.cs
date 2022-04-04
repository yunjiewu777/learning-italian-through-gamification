using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum GoodsType
{
    score
}

[System.Serializable]
public struct MissionGoods
{
    public GoodsType goodsType;
    public int[] goodsCount;

}
[System.Serializable]
public struct MissionData
{
    public string name;
    public string des;
    public int id;
    public MissionGoods needGoods;

}

[CreateAssetMenu(fileName ="NewMissionDatabase",menuName = "CreateNewMissionDatabase")]
public class MissionDatabase : ScriptableObject
{
    public List<MissionData> missionTasks;
}
