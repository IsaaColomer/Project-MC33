using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy1 : MonoBehaviour
{
    private static bool playerExists = false;
    // Start is called before the first frame update
    void Start()
    {
        if(!playerExists)
        {
            Debug.Log("Created player!!");
            playerExists = true;
            DontDestroyOnLoad(transform.gameObject);            
        }
        else
        {
            Debug.Log("Destroyed player!!");
            Destroy(gameObject);
        }
        
    }
}
