using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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


    public Scene scene;

    public void Awake()
    {

        SaveMangerDone.instance.DeleteSavedData();
        scene = SceneManager.GetActiveScene();
        GameObject pos03 = GameObject.Find("PlayerGeneral");
        FallRestart pos04 = pos03.GetComponent<FallRestart>();
        

         if(scene.name == "Lvl1")
         { 
            Debug.Log("scene 1 loaded");
            pos04.rb.transform.position = SaveMangerDone.instance.activeSave.respawnPosition;
            SaveMangerDone.instance.Load();
         }
    }

    private void Update()
    {
        if(IsGrounded())
        {
            GameObject v = GameObject.Find("PlayerGeneral");
            DoubleJumpOnOff b = v.GetComponent<DoubleJumpOnOff>();
        

            b.spriteDoubleJump = true;

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
                    GameObject vz = GameObject.Find("PlayerGeneral");
                    DoubleJumpOnOff bz = vz.GetComponent<DoubleJumpOnOff>();
        
                    bz.spriteDoubleJump = false;
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

            GameObject vs = GameObject.Find("PlayerGeneral");
            DoubleJumpOnOff bs = vs.GetComponent<DoubleJumpOnOff>();        
            bs.spriteDoubleJump = true;
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
            GameObject va = GameObject.Find("PlayerGeneral");
            DoubleJumpOnOff ba = va.GetComponent<DoubleJumpOnOff>();
        
            ba.spriteDoubleJump = true;
        }
    }
}
