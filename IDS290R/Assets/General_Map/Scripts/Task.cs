using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New Record", menuName = "Record")]
public class Task : ScriptableObject
{
    public string taskName;
    public int[] score = new int[5];
}
