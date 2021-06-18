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
}
