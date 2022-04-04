using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Save
{ 
    public PlayerData MyPlayerData { get; set; }
    public Save()
    { 
        
    
    }
}

[System.Serializable]
public class PlayerData
{
    public int MyLevel { get; set; }
    public int[] GameA { get; set; }
    public int[] GameM { get; set; }
    public int[] GameT { get; set; }

    public PlayerData(Level level, Task minigameA, Task minigameM, Task minigameT)
    {
        MyLevel = level.difficultyLevel;
        GameA = minigameA.score;
        GameM = minigameM.score;
        GameT = minigameT.score;

    }
}
