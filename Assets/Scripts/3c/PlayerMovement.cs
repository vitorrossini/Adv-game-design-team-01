using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // movement and jump script, also useful to check where it stands

    public LevelRotation lvlRot;
    public float moveSpeed;
    private float breakSpeed;
    public float jumpForce;
   

    public int jumpsAmount;
    private int jumpsLeft;
    public Transform GroundCheck;
    public LayerMask GroundLayer;

    public bool isGrounded;
    public bool onTurnPlat;

    public float moveInput;
    Rigidbody2D rb2d;
    float scaleX;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        lvlRot = gameObject.GetComponent<LevelRotation>();
        scaleX = transform.localScale.x;
        breakSpeed = 1f;
        onTurnPlat = false;
    }

    // Update is called once per frame
    public void Update()
    {

        moveInput = Input.GetAxisRaw("Horizontal");
        Jump();

        if (onTurnPlat && Input.GetButton("Rotate")) // if you are on the rotating platform and you are pressing the button to rotate the level
        {

            breakSpeed = 0; // doesnt let the player move
        }
        else
        {
            breakSpeed = 1f; // goes back to normal
        }

        CheckIfGrounded(); // always checks if its standing somewhere or else it would change the behaviour of the sound and the level rotation
        

    }

    private void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        Flip();
        rb2d.velocity = new Vector2(moveInput * moveSpeed * breakSpeed, rb2d.velocity.y); // i feel like i could work on this better

    }

    public void Flip() // flip the sprites and animations as you move to the other side
    {
        if (moveInput > 0)
        {
            transform.localScale = new Vector3(scaleX, transform.localScale.y, transform.localScale.z);
        }
        if (moveInput < 0)
        {
            transform.localScale = new Vector3((-1) * scaleX, transform.localScale.y, transform.localScale.z);
        }
    }

    public void Jump()
    {

        if (Input.GetButtonDown("Jump"))
        {
            
            if (isGrounded && jumpsLeft > 0) // check the amount of jumps
            {
                rb2d.velocity = new Vector2(rb2d.velocity.x, jumpForce);
                jumpsLeft --; // decrease one
            }

        }

    }

    public void CheckIfGrounded()
    {
        RaycastHit hit;

        
       
        isGrounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheck.GetComponent<CircleCollider2D>().radius, GroundLayer); // checks the ground based on the circle collider attached to an empty object below the player
        
        ResetJumps();
    }

    public void ResetJumps()
    {
        if (isGrounded)
        {
            jumpsLeft = jumpsAmount;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("CanTurn")) // checks if the player is standing on the platform that allows level rotation
        {
            onTurnPlat = true;
       
           
        }
        else
        {
           onTurnPlat = false;
        }
    }

   
}
