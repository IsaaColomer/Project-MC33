using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementFirst : MonoBehaviour
{
    public CharacterController2D controller;
    public GameObject player;
    public bool isGrounded = false;
    public bool doubleJump;
    [SerializeField] private LayerMask GroundMask;
    public Rigidbody2D rb;
    public float runSpeed = 40f;
    public float jumpVel = 10f;
    public CapsuleCollider2D capsCol;
    float horizontalMove = 0f;
    public Collider2D attachCol;

    public void Awake()
    {
        GameObject p = GameObject.Find("Saving");
        SaveMangerDone h = p.GetComponent<SaveMangerDone>();

      
            GameObject pos03 = GameObject.Find("PlayerGeneral");
            FallRestart pos04 = pos03.GetComponent<FallRestart>();
            pos04.rb.transform.position = SaveMangerDone.instance.activeSave.respawnPosition;
            SaveMangerDone.instance.Load();

            // GameObject m = GameObject.Find("PlayerGeneral");
            // FallRestart n = m.GetComponent<FallRestart>();
            // n.rb.transform.position = new Vector3(-25.57f,2.36f,0f);    
    }

    private void Update()
    {
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
