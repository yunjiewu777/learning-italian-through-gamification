using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMatch : MonoBehaviour
{
    private void Awake()
    {
        gameObject.transform.GetChild(SaveManager.GetInstance().level.difficultyLevel-1).gameObject.SetActive(true);
    }

}
