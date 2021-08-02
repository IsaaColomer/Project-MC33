using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    public bool newPosition;
    // Start is called before the first frame update
    public void LoadGame()
    {        
        SceneManager.LoadScene(PlayerPrefs.GetInt("SavedScene"));
        newPosition = true;
    }
    public void LoadPosition()
    {                                    
        
    }
}
