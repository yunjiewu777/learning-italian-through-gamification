using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    private BoxCollider2D boxCollider;
    private Rigidbody2D rb;
    private Vector3 moveDelta;
    private Animator anim;
    private Vector3 change;
    private RaycastHit2D hit;
    public float moveSpeed = 7f;
    public VectorValue startingPosition;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        Time.timeScale = 1f;
        anim = GetComponent<Animator>();
        transform.position = startingPosition.initialValue;
    }

    private void Update()
    {
        SwitchAnim();
    }

    void SwitchAnim()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");

        if (change != Vector3.zero)
        {
            anim.SetFloat("moveX", change.x);
            anim.SetFloat("moveY", change.y);
            anim.SetBool("moving", true);
        }
        else {
            anim.SetBool("moving", false);
        }
    }


    private void FixedUpdate()
    {
        Move();

        
    }

    private void Move() 
    {
        if (DialogueManager.GetInstance().dialogueIsPlaying)
            return;

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        moveDelta = new Vector3(x, y, 0);

        // make sure we can move up/down
        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(0, moveDelta.y), Mathf.Abs(moveDelta.y * Time.deltaTime * moveSpeed), LayerMask.GetMask("NPC", "Blocking"));
        if (hit.collider == null)
        {
            transform.Translate(0, moveSpeed * moveDelta.y * Time.fixedDeltaTime, 0);
        }

        // make sure we can move right/left
        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(moveDelta.x, 0), Mathf.Abs(moveDelta.x * Time.deltaTime * moveSpeed), LayerMask.GetMask("NPC", "Blocking"));
        if (hit.collider == null)
        {
            transform.Translate(moveSpeed * moveDelta.x * Time.fixedDeltaTime, 0, 0);
        }
    }

}
