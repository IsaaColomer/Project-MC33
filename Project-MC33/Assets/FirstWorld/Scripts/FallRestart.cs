using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FallRestart : MonoBehaviour
{
    public AudioSource nut;
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
    if(!SaveMangerDone.instance.activeSave.firstCheckDone)
    {
        startPos = new Vector3(-24f,1.6f,0f);
        rb.transform.position = startPos;
    }
    else
    {
        startPos = SaveMangerDone.instance.activeSave.respawnPosition;
        rb.transform.position = startPos;
    }

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
        nut.Play();
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
        nut.Play();
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
               nut.Play();
        }
    if(other.gameObject.layer == LayerMask.NameToLayer("ChangeLvl"))
    {
        restartDoubleJump = true;
        mainCamera.transform.position = new Vector3(other.transform.position.x,other.transform.position.y,-9.8f);
    }
    }
}
