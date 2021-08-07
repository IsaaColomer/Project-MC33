using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashAbility : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    public int direction;
    public bool dashOn;
    // Start is called before the first frame update
    void Start()
    {
        //rb = gameObject.GetComponent<RigidBody2D>();
        dashTime = startDashTime;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetKeyDown("space"))
        {
            Dash();
        }
        
    
    }
    public void Dash()
    {
        if(direction == 0)
        {
            if(Input.GetKeyDown("left"))
            {
                direction = 1;
            }
            else if(Input.GetKeyDown("right"))
            {
                direction = 2;
            }
        }
        else
        {
            if(dashTime <= 0)
            {
                direction = 0;
                dashTime = startDashTime;
                rb.velocity = Vector2.zero;
            }
            else
            {
                dashTime -= Time.deltaTime;
                if(direction == 1)
                {
                    rb.velocity = Vector2.left * dashSpeed;
                }
                else if(direction == 2)
                {
                    rb.velocity = Vector2.right * dashSpeed;
                }
            }
        }
    }
}
