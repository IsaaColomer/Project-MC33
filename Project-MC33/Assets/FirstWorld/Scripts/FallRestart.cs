using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallRestart : MonoBehaviour
{
    public bool dead = false;
    public bool restartDoubleJump = false;
    public Rigidbody2D rb;
    public Rigidbody2D chRb;
    public Vector3 startPos;
    public Vector3 restartPos;
    public int death;
    // public GameObject rj1;
    // public GameObject rj2;
    // public GameObject rj3;
    // public GameObject rj4;
    // public GameObject rj5;
    // public GameObject rj6;
    // public GameObject rj7;
    // Start is called before the first frame update
    void Start()
    {
        death = 0;
        startPos = rb.transform.position;
        restartPos = startPos;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
    if(col.gameObject.layer == LayerMask.NameToLayer("Ground"))
    {
        restartDoubleJump = false;
        dead = false;
    }
    if(col.gameObject.layer == LayerMask.NameToLayer("Spikes"))
    {
        restartDoubleJump = true;
        dead = true;
        
        GameObject grap = GameObject.Find("PlayerGeneral");
        GrapDetection grap2 = grap.GetComponent<GrapDetection>();

        GameObject lol = GameObject.Find("PlayerGeneral");
        GrapDetection lol2 = lol.GetComponent<GrapDetection>();

        rb.transform.position = startPos;
        lol2.grapOn = false;
        grap2._distanceJoint.enabled = false;
        
       
        // rj1.SetActive(true);
        // rj2.SetActive(true);
        // rj3.SetActive(true);
        // rj4.SetActive(true);
        // rj5.SetActive(true);
        // rj6.SetActive(true);
        // rj7.SetActive(true);
        death++;
    }
    if(col.gameObject.layer == LayerMask.NameToLayer("Fall"))
    {
        
        restartDoubleJump = true;
        dead = true;
        rb.transform.position = startPos;

        GameObject grap = GameObject.Find("PlayerGeneral");
        GrapDetection grap2 = grap.GetComponent<GrapDetection>();

        GameObject lol = GameObject.Find("PlayerGeneral");
        GrapDetection lol2 = lol.GetComponent<GrapDetection>();

        lol2.grapOn = false;
        grap2._distanceJoint.enabled = false;

        // rj1.SetActive(true);
        // rj2.SetActive(true);
        // rj3.SetActive(true);
        // rj4.SetActive(true);
        // rj5.SetActive(true);
        // rj6.SetActive(true);
        // rj7.SetActive(true);

        Debug.Log("lol");
        death++;
    }
    }
    public Camera mainCamera;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
            if(other.gameObject.name == "ChageLevel01")
            {
                restartDoubleJump = true;
                mainCamera.transform.position = new Vector3(other.transform.position.x,0f,-9.8f);           
            }
            if(other.gameObject.name == "ChageLevel02")
            {
                restartDoubleJump = true;
                mainCamera.transform.position = new Vector3(other.transform.position.x,0f,-9.8f);
                //startPos = rb.transform.position;      
            }
            if(other.gameObject.name == "ChageLevel03")
            {
                restartDoubleJump = true;
                mainCamera.transform.position = new Vector3(other.transform.position.x,0f,-9.8f);
               // startPos = rb.transform.position;      
            }
             if(other.gameObject.name == "ChageLevel04")
            {
                restartDoubleJump = true;
                mainCamera.transform.position = new Vector3(other.transform.position.x,0f,-9.8f);
               // startPos = rb.transform.position;      
            }
             if(other.gameObject.name == "ChageLevel05")
            {
                restartDoubleJump = true;
                mainCamera.transform.position = new Vector3(other.transform.position.x,0f,-9.8f);
                //startPos = rb.transform.position;      
            }
             if(other.gameObject.name == "ChageLevel06")
            {
                restartDoubleJump = true;
                mainCamera.transform.position = new Vector3(other.transform.position.x,other.transform.position.y,-9.8f);
                //startPos = rb.transform.position;      
            }
             if(other.gameObject.name == "ChageLevel07")
            {
                restartDoubleJump = true;
                mainCamera.transform.position = new Vector3(other.transform.position.x,other.transform.position.y,-9.8f);
                //startPos = rb.transform.position;      
               //ceneManager.LoadScene("Credits");    
            }
             if(other.gameObject.name == "ChageLevel08")
            {
                mainCamera.transform.position = new Vector3(other.transform.position.x,0f,-9.8f);
                //startPos = rb.transform.position;      
            }
             if(other.gameObject.name == "ChageLevel09")
            {
                restartDoubleJump = true;
                mainCamera.transform.position = new Vector3(other.transform.position.x,0f,-9.8f);
                //startPos = rb.transform.position;      
            }
             if(other.gameObject.name == "ChageLevel10")
            {
                restartDoubleJump = true;
                mainCamera.transform.position = new Vector3(other.transform.position.x,0f,-9.8f);
               // startPos = rb.transform.position;      
            }
             if(other.gameObject.name == "ChageLevel11")
            {
                restartDoubleJump = true;
                mainCamera.transform.position = new Vector3(other.transform.position.x,0f,-9.8f);
                //startPos = rb.transform.position;      
            }

    }
}
