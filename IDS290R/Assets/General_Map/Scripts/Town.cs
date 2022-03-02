using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Town : MonoBehaviour
{
    public Vector2 playerPosition;
    public VectorValue plyaerStorage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            plyaerStorage.initialValue = playerPosition;
            SceneManager.LoadScene("Town");
        }
    }
}
