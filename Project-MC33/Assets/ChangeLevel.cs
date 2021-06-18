using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    public Rigidbody2D rb;
    public BoxCollider2D col;
    public Camera mainCamera;
    void Update()
    {

    }
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
            if(other.gameObject.name == "ChangeLevel01")
            {
                Debug.Log("coño");
                mainCamera.transform.position = new Vector3(0f,0f,-9.8f);
           
            }
            if(other.gameObject.name == "ChangeLevel02")
            {
                Debug.Log("pito");
                mainCamera.transform.position = new Vector3(53f,0f,-9.8f);
           
            }
    }
}
