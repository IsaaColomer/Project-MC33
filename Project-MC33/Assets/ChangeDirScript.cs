using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDirScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject walkEn;
    public int velocity;
    public bool isLeft;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        if(isLeft)
            rb.velocity = transform.right * -velocity;
        else
        {
            rb.velocity = transform.right * velocity;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.layer == LayerMask.NameToLayer("ChangeDirectionLeft"))
        {
            rb.velocity = transform.right * (velocity+2);
        }
        if(col.gameObject.layer == LayerMask.NameToLayer("ChangeDirectionRight"))
        {
            rb.velocity = transform.right * -(velocity+2);
        }
    }
}
