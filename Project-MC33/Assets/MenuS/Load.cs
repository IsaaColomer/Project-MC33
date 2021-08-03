using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadGame()
    {        
        GameObject p = GameObject.Find("Saving");
        SaveMangerDone h = p.GetComponent<SaveMangerDone>();
        h.newGame = false;
        SceneManager.LoadScene(PlayerPrefs.GetInt("SavedScene"));
    }
    public void LoadPosition()
    {                                    
        
    }
}
