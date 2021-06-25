using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallRestart : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector3 startPos;
    public int death;
    public GameObject rj1;
    public GameObject rj2;
    public GameObject rj3;
    public GameObject rj4;
    public GameObject rj5;
    public GameObject rj6;
    public GameObject rj7;
    // Start is called before the first frame update
    void Start()
    {
        death = 0;
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
        rj1.SetActive(true);
        rj2.SetActive(true);
        rj3.SetActive(true);
        rj4.SetActive(true);
        rj5.SetActive(true);
        rj6.SetActive(true);
        rj7.SetActive(true);
        death++;
    }
    if(col.gameObject.layer == LayerMask.NameToLayer("Fall"))
    {
        rb.transform.position = startPos;
        rj1.SetActive(true);
        rj2.SetActive(true);
        rj3.SetActive(true);
        rj4.SetActive(true);
        rj5.SetActive(true);
        rj6.SetActive(true);
        rj7.SetActive(true);
        death++;
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
             if(other.gameObject.name == "ChageLevel04")
            {
                mainCamera.transform.position = new Vector3(other.transform.position.x,0f,-9.8f);
                startPos = rb.transform.position;      
            }
             if(other.gameObject.name == "ChageLevel05")
            {
                mainCamera.transform.position = new Vector3(other.transform.position.x,0f,-9.8f);
                startPos = rb.transform.position;      
            }
             if(other.gameObject.name == "ChageLevel06")
            {
                
                mainCamera.transform.position = new Vector3(other.transform.position.x,other.transform.position.y,-9.8f);
                startPos = rb.transform.position;      
            }
             if(other.gameObject.name == "ChageLevel07")
            {
                mainCamera.transform.position = new Vector3(other.transform.position.x,other.transform.position.y,-9.8f);
                startPos = rb.transform.position;      
               //ceneManager.LoadScene("Credits");    
            }
             if(other.gameObject.name == "ChageLevel08")
            {
                mainCamera.transform.position = new Vector3(other.transform.position.x,0f,-9.8f);
                startPos = rb.transform.position;      
            }
             if(other.gameObject.name == "ChageLevel09")
            {
                mainCamera.transform.position = new Vector3(other.transform.position.x,0f,-9.8f);
                startPos = rb.transform.position;      
            }
             if(other.gameObject.name == "ChageLevel10")
            {
                mainCamera.transform.position = new Vector3(other.transform.position.x,0f,-9.8f);
                startPos = rb.transform.position;      
            }
             if(other.gameObject.name == "ChageLevel11")
            {
                mainCamera.transform.position = new Vector3(other.transform.position.x,0f,-9.8f);
                startPos = rb.transform.position;      
            }
           

    }
}
