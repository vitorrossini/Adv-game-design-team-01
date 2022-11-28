
using UnityEngine;

public class Movement : MonoBehaviour
{
    public ParametersSetByName music;
    public LevelRotation lvlRot;
    public float moveSpeed;
    private float breakSpeed;
    public float jumpForce;

    public int jumpsAmount;
   private  int jumpsLeft;
    public Transform GroundCheck;
    public LayerMask GroundLayer;

    private bool isGrounded;
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

        if (onTurnPlat && Input.GetButton("Rotate"))
        {

            breakSpeed = 0;
        }
        else
        {
            breakSpeed = 1f;
        }
        
        

    }

    private void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        Flip();
        rb2d.velocity = new Vector2(moveInput * moveSpeed * breakSpeed, rb2d.velocity.y);
    }

    public void Flip()
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
            CheckIfGrounded();
            if (jumpsLeft > 0)
            {
                rb2d.velocity = new Vector2(rb2d.velocity.x, jumpForce);
                jumpsLeft--;
            }

        }

    }

    public void CheckIfGrounded()
    {
        isGrounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheck.GetComponent<CircleCollider2D>().radius, GroundLayer);
        ResetJumps();
    }

    public void ResetJumps()
    {
        if (isGrounded)
        {
            jumpsLeft = jumpsAmount;// jumpsAmount =2;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("CanTurn"))
        {
            onTurnPlat = true;
            music.RotatePiano1();
            Debug.LogError("woow");
        }
        else
        {
            
            onTurnPlat = false;
        }
    }




}
