using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementFirst : MonoBehaviour
{
    public CharacterController2D controller;
    public bool isGrounded = false;
    public bool doubleJump;
    [SerializeField] private LayerMask GroundMask;
    public Rigidbody2D rb;
    public float runSpeed = 40f;
    public float jumpVel = 10f;
    public BoxCollider2D boxCol;
    float horizontalMove = 0f;
    // Start is called before the first frame update
    private void Awake()
    {

    }

    private void Update()
    {
                
        horizontalMove = Input.GetAxisRaw("Horizontal")*runSpeed;
        if(IsGrounded() && Input.GetKeyDown("z"))
        {
            doubleJump = true;
            rb.velocity = (Vector2.up) * jumpVel;
        }
        if(doubleJump == true && Input.GetKeyDown("z"))
        {
             rb.velocity = (Vector2.up/2) * (jumpVel);
             doubleJump = false;
        }
    }
   
    private bool IsGrounded()
    {
       RaycastHit2D rayCasthit2D = Physics2D.BoxCast(boxCol.bounds.center, boxCol.bounds.size, 0f, Vector2.down, 1f, GroundMask);
        if(rayCasthit2D.collider != null)
        {
            isGrounded = true;
            doubleJump = false;
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
}
