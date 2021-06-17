using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementFirst : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.GetAxisRaw("Horizontal"));
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        FixeUpdate();
    }

    void FixeUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime,false,jump);
        jump = false;
    }
}
