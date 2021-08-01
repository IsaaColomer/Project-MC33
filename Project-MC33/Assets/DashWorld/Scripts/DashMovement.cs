using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public bool isGrounded = false;
    public bool doubleJump;
    [SerializeField] private LayerMask GroundMask;
    public Rigidbody2D rb;
    public float runSpeed = 40f;
    public float jumpVel = 10f;
    public CapsuleCollider2D capsCol;
    float horizontalMove = 0f;
    public Collider2D attachCol;
    public float slideCount = 0f;
    public float maxSlideCount = 10f;
    public CapsuleCollider2D breakCol;
    public bool facingLeft;
    // Start is called before the first frame update
    private void Awake()
    {

    }

    private void Update()
    {
        if(Input.GetKeyDown("left"))
        {
            Debug.Log("Facing Left");
            facingLeft = true;
        }
        if(Input.GetKeyDown("right"))
        {
            facingLeft = false;
        }
        if(Input.GetKeyDown(KeyCode.C))
        {
            slideCount+=Time.deltaTime;            
            if(slideCount<maxSlideCount)
            {
                if(facingLeft == true)
                {                   
                    rb.AddRelativeForce(Vector2.left * 28000f);
                    breakCol.enabled = false;                    
                }
                if(facingLeft == false)
                {                    
                    rb.AddRelativeForce(Vector2.right * 28000f);
                    breakCol.enabled = false;
                }                
            }
            else
            {
                Debug.Log("Now Col");
                breakCol.enabled = true;
                slideCount = 0;
            }
        }
        
        if(IsGrounded())
        {
            doubleJump = true;
        }
                
        horizontalMove = Input.GetAxisRaw("Horizontal")*runSpeed;

        if(Input.GetKeyDown(KeyCode.Z))
        {
            if(IsGrounded())
            {
                rb.velocity = (Vector2.up) * jumpVel;
            } else
            {
                if(doubleJump)
                {
                    rb.velocity = (Vector2.up) * (jumpVel);
                    doubleJump = false;
                }
            }
        }
             
    }
   
    private bool IsGrounded()
    {
       RaycastHit2D rayCasthit2D = Physics2D.BoxCast(capsCol.bounds.center, capsCol.bounds.size, 0f, Vector2.down, 1f, GroundMask);
        if(rayCasthit2D.collider != null)
        {
            isGrounded = true;
            doubleJump = true;
        }
        else
        {
            isGrounded = false;
        }
       return rayCasthit2D.collider != null;
    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove*Time.fixedDeltaTime,false,false);
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.layer == LayerMask.NameToLayer("resetJump"))
        {
            doubleJump = true;
        }
    }
}

