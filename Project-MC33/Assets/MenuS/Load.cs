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
        Debug.Log("Player position Loaded");
        SceneManager.LoadScene(PlayerPrefs.GetInt("SavedScene"));

        GameObject pos01 = GameObject.Find("CheckPoints");
        CheckPoints pos02 = pos01.GetComponent<CheckPoints>();

        GameObject posF = GameObject.Find("PlayerGeneral");
        MovementFirst posF1 = posF.GetComponent<MovementFirst>();

        posF1.player.transform.position = pos02.posPlayer;
    }
}
