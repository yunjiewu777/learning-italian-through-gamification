using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New Minigame", menuName = "Minigame")]
public class Task : ScriptableObject
{
    public string taskName;
    public List<int> score;
}
