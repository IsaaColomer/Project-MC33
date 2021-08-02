using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    public int levelLol;
    // Start is called before the first frame update
    public void LoadGame()
    {
        
        SceneManager.LoadScene(PlayerPrefs.GetInt("SavedScene"));
        Debug.Log("Player position Loaded");
        GameObject posF = GameObject.Find("PlayerGeneral");
        MovementFirst posF1 = posF.GetComponent<MovementFirst>();

        posF1.LoadPlayer();
    }
}
