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
        GameObject save01 = GameObject.Find("PlayerGeneral");
        MovementFirst save02 = save01.GetComponent<MovementFirst>();

        save02.LoadPlayer();
        Debug.Log("Player position Loaded");
        // GameObject pos01 = GameObject.Find("KnowLvl");
        // KnowLevel pos02 = pos01.GetComponent<KnowLevel>();
        
        // SceneManager.LoadScene(pos02.level);
        SceneManager.LoadScene("Lvl1");
    }
}
