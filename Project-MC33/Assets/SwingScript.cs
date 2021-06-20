using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingScript : MonoBehaviour
{
        public BoxCollider2D Swing;
        public CapsuleCollider2D playerCol;
        public GameObject lol;
        public GameObject player;
        public Rigidbody2D rb;
        public bool attached =  false;
    // Start is called before the first frame update
    void Start()
    {
       // lol = transform.gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(attached == false)
        {
          if(col.gameObject.layer == LayerMask.NameToLayer("Swing"))
        {
                lol.GetComponent<DistanceJoint2D>().connectedBody = player.GetComponent<Rigidbody2D>();
                attached = true;
        }
        }

    }
}
