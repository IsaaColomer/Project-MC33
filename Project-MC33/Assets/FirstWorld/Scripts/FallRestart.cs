using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallRestart : MonoBehaviour
{
    public bool dead = false;
    public bool restartDoubleJump = false;
    public Rigidbody2D rb;
    public Vector3 startPos;
    public Vector3 restartPos;
    public CapsuleCollider2D walEnemyCol;
    public int death;

    void Start()
    {
        death = SaveMangerDone.instance.activeSave.deaths;
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
 
        death++;
        SaveMangerDone.instance.activeSave.deaths++;
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

        Debug.Log("lol");
        death++;
        SaveMangerDone.instance.activeSave.deaths++;
    }
    if(col.collider == walEnemyCol)
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

        Debug.Log("Cum");
        death++;
        SaveMangerDone.instance.activeSave.deaths++;
    }
    }
    public Camera mainCamera;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("Enemies"))
    {
        GameObject a = GameObject.Find("PlayerGeneral");
        GrapDetection a1 = a.GetComponent<GrapDetection>();

        GameObject b = GameObject.Find("PlayerGeneral");
        GrapDetection b1 = b.GetComponent<GrapDetection>();

        rb.transform.position = startPos;
        b1.grapOn = false;
        a1._distanceJoint.enabled = false;

        restartDoubleJump = true;
        dead = true;
        death++;
        SaveMangerDone.instance.activeSave.deaths++;
    }
    if(other.gameObject.layer == LayerMask.NameToLayer("ChangeLvl"))
    {
        restartDoubleJump = true;
        mainCamera.transform.position = new Vector3(other.transform.position.x,other.transform.position.y,-9.8f);
    }
            // if(other.gameObject.name == "ChageLevel01")
            // {
            //     restartDoubleJump = true;
            //     mainCamera.transform.position = new Vector3(other.transform.position.x,other.transform.position.y,-9.8f);        
            // }
            // if(other.gameObject.name == "ChageLevel02")
            // {
            //     restartDoubleJump = true;
            //  mainCamera.transform.position = new Vector3(other.transform.position.x,other.transform.position.y,-9.8f);
            //     //startPos = rb.transform.position;      
            // }
            // if(other.gameObject.name == "ChageLevel03")
            // {
            //     restartDoubleJump = true;
            //   mainCamera.transform.position = new Vector3(other.transform.position.x,other.transform.position.y,-9.8f);
            //    // startPos = rb.transform.position;      
            // }
            //  if(other.gameObject.name == "ChageLevel04")
            // {
            //     restartDoubleJump = true;
            //     mainCamera.transform.position = new Vector3(other.transform.position.x,other.transform.position.y,-9.8f);
            //    // startPos = rb.transform.position;      
            // }
            //  if(other.gameObject.name == "ChageLevel05")
            // {
            //     restartDoubleJump = true;
            //    mainCamera.transform.position = new Vector3(other.transform.position.x,other.transform.position.y,-9.8f);
            //     //startPos = rb.transform.position;      
            // }
            //  if(other.gameObject.name == "ChageLevel06")
            // {
            //     restartDoubleJump = true;
            //     mainCamera.transform.position = new Vector3(other.transform.position.x,other.transform.position.y,-9.8f);
            //     //startPos = rb.transform.position;      
            // }
            //  if(other.gameObject.name == "ChageLevel07")
            // {
            //     restartDoubleJump = true;
            //     mainCamera.transform.position = new Vector3(other.transform.position.x,other.transform.position.y,-9.8f);
            //     //startPos = rb.transform.position;      
            //    //ceneManager.LoadScene("Credits");    
            // }
            //  if(other.gameObject.name == "ChageLevel08")
            // {
            //     mainCamera.transform.position = new Vector3(other.transform.position.x,other.transform.position.y,-9.8f);
            //     //startPos = rb.transform.position;      
            // }
            //  if(other.gameObject.name == "ChageLevel09")
            // {
            //     restartDoubleJump = true;
            //     mainCamera.transform.position = new Vector3(other.transform.position.x,other.transform.position.y,-9.8f);
            //     //startPos = rb.transform.position;      
            // }
            //  if(other.gameObject.name == "ChageLevel10")
            // {
            //     restartDoubleJump = true;
            //     mainCamera.transform.position = new Vector3(other.transform.position.x,other.transform.position.y,-9.8f);
            //    // startPos = rb.transform.position;      
            // }
            //  if(other.gameObject.name == "ChageLevel11")
            // {
            //     restartDoubleJump = true;
            //     mainCamera.transform.position = new Vector3(other.transform.position.x,other.transform.position.y,-9.8f);
            //     //startPos = rb.transform.position;      
            // }
            //  if(other.gameObject.name == "ChageLevel12")
            // {
            //     restartDoubleJump = true;
            //     mainCamera.transform.position = new Vector3(other.transform.position.x,other.transform.position.y,-9.8f);
            //     //startPos = rb.transform.position;      
            // }
            //  if(other.gameObject.name == "ChageLevel13")
            // {
            //     restartDoubleJump = true;
            //     mainCamera.transform.position = new Vector3(other.transform.position.x,other.transform.position.y,-9.8f);
            //     //startPos = rb.transform.position;      
            // }
            //  if(other.gameObject.name == "ChageLevel14")
            // {
            //     restartDoubleJump = true;
            //     mainCamera.transform.position = new Vector3(other.transform.position.x,other.transform.position.y,-9.8f);
            //     //startPos = rb.transform.position;      
            // }
            //  if(other.gameObject.name == "ChageLevel15")
            // {
            //     restartDoubleJump = true;
            //     mainCamera.transform.position = new Vector3(other.transform.position.x,other.transform.position.y,-9.8f);
            //     //startPos = rb.transform.position;      
            // }
            //  if(other.gameObject.name == "ChageLevel16")
            // {
            //     restartDoubleJump = true;
            //     mainCamera.transform.position = new Vector3(other.transform.position.x,other.transform.position.y,-9.8f);
            //     //startPos = rb.transform.position;      
            // }
            //  if(other.gameObject.name == "ChageLevel17")
            // {
            //     restartDoubleJump = true;
            //     mainCamera.transform.position = new Vector3(other.transform.position.x,other.transform.position.y,-9.8f);
            //     //startPos = rb.transform.position;      
            // }
            //  if(other.gameObject.name == "ChageLevel18")
            // {
            //     restartDoubleJump = true;
            //     mainCamera.transform.position = new Vector3(other.transform.position.x,other.transform.position.y,-9.8f);
            //     //startPos = rb.transform.position;      
            // }
    }
}
