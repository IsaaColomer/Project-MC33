using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject save01 = GameObject.Find("PlayerGeneral");
        MovementFirst save02 = save01.GetComponent<MovementFirst>();
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            save02.SavePlayer();
            Debug.Log("player position saved!");
            SceneManager.LoadScene("Options");
        }
    }
}
