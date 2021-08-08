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
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("player position saved!");
            SaveMangerDone.instance.Save();
            PlayerPrefs.SetInt("SavedScene", SceneManager.GetActiveScene().buildIndex);
            SceneManager.LoadScene("Options");
        }
    }
}
