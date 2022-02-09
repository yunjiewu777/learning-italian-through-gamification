using UnityEngine;

public class ShowText : MonoBehaviour
{
    public GameObject end;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            end.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            end.SetActive(false);

        }
    }
}
