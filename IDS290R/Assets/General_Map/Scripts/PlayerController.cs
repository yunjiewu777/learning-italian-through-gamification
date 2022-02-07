using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 1f;
    public ContactFilter2D movementFilter;
    public float collisionOffset = 0.5f;
    public GameObject player;
    public Collider2D coll;

    SpriteRenderer sr;
    Animator anim;
    Vector2 movementInput;
    Rigidbody2D rb;

    List<RaycastHit2D> castCollsions = new List<RaycastHit2D>();

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        if (tryMove())
            Move();
  
    }

    private void Update()
    {
        SwitchAnim();
    }

    private void Move()
    {
        float horizontalMove = Input.GetAxisRaw("Horizontal");
        float verticalMove = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(horizontalMove * moveSpeed, verticalMove * moveSpeed);

        if (horizontalMove != 0)
        {
            transform.localScale = new Vector3(horizontalMove, 1, 1);
        }
    }


    void SwitchAnim()
    {

        float horizontalMove = Input.GetAxisRaw("Horizontal");
        float verticalMove = Input.GetAxisRaw("Vertical");

        anim.SetBool("idle", true);
        if (horizontalMove != 0 | verticalMove != 0)
            anim.SetBool("idle", false);

        if (verticalMove > 0)
        {
            anim.SetBool("up", true);
            anim.SetBool("down", false);
        }
        else if (verticalMove < 0)
        {
            anim.SetBool("up", false);
            anim.SetBool("down", true);
        }

        else if (horizontalMove != 0)
        {
            anim.SetBool("up", false);
            anim.SetBool("down", false);
        }
    }

    private bool tryMove() 
    {

        float horizontalMove = Input.GetAxisRaw("Horizontal");
        float verticalMove = Input.GetAxisRaw("Vertical");

        movementInput = new Vector2(horizontalMove, verticalMove);

        int count = rb.Cast(
          movementInput,
          movementFilter,
          castCollsions,
          moveSpeed * Time.fixedDeltaTime + collisionOffset);

        return count == 0;


    }


}
