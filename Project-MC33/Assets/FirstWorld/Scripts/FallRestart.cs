using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallRestart : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = rb.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
    if(col.gameObject.layer == LayerMask.NameToLayer("Spikes"))
    {
        rb.transform.position = startPos;
    }
    if(col.gameObject.layer == LayerMask.NameToLayer("Fall"))
    {
        rb.transform.position = startPos;
    }
    }
     public Camera mainCamera;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
            if(other.gameObject.name == "ChageLevel01")
            {
                mainCamera.transform.position = new Vector3(other.transform.position.x,0f,-9.8f);           
            }
            if(other.gameObject.name == "ChageLevel02")
            {
                mainCamera.transform.position = new Vector3(other.transform.position.x,0f,-9.8f);
                startPos = rb.transform.position;      
            }
            if(other.gameObject.name == "ChageLevel03")
            {
                mainCamera.transform.position = new Vector3(other.transform.position.x,0f,-9.8f);
                startPos = rb.transform.position;      
            }
    }
}
