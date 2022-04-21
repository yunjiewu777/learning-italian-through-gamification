using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSave : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SaveManager.GetInstance().Save();
            Destroy(GetComponent<TriggerSave>());
        }
    }

}
