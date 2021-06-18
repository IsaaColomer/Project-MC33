using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    public Rigidbody2D rb;
    public BoxCollider2D col01;
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
            }
    }
}
