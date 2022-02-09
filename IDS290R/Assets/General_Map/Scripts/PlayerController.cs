using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    private BoxCollider2D boxCollider;
    private Vector3 moveDelta;
    Animator anim;
    private RaycastHit2D hit;
    public float moveSpeed = 3f;

    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        Time.timeScale = 1f;
        // rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
//        sr = GetComponent<SpriteRenderer>();
    }


    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        moveDelta = new Vector3(x, y, 0);

        //right or left
        if (moveDelta.x != 0)
            transform.localScale = new Vector3(x, 1, 1);

        /*
        if (moveDelta.y > 0)
        {
            anim.SetBool("down", false);
            anim.SetBool("up", true);
        }
        else if (moveDelta.y < 0) 
        {
            anim.SetBool("down", true);
            anim.SetBool("up", false);
        }
        */

        // make sure we can move up/down
        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(0, moveDelta.y), Mathf.Abs(moveDelta.y * Time.deltaTime * moveSpeed), LayerMask.GetMask("NPC", "Blocking"));
        if (hit.collider == null) 
        {
            transform.Translate(0, moveSpeed * moveDelta.y * Time.fixedDeltaTime,0);
        }

        // make sure we can move right/left
        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(moveDelta.x,0), Mathf.Abs(moveDelta.x * Time.deltaTime * moveSpeed), LayerMask.GetMask("NPC", "Blocking"));
        if (hit.collider == null)
        {
            transform.Translate(moveSpeed * moveDelta.x * Time.fixedDeltaTime,0,0);
        }


    }




    /*
    public ContactFilter2D movementFilter;
    public float collisionOffset = 0.5f;
    public GameObject player;
    public Collider2D coll;

    SpriteRenderer sr;
    Vector2 movementInput;
    Rigidbody2D rb;

    List<RaycastHit2D> castCollsions = new List<RaycastHit2D>();

    // Start is called before the first frame update
    


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

    */
}
