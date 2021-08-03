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

        // GameObject lol = GameObject.Find("Saving");
        // SaveMangerDone lol1 = lol.GetComponent<SaveMangerDone>();

        SaveMangerDone.instance.Save();
        //lol1.Load();

        //newPosition = true;
    }
    public void LoadPosition()
    {                                    
        
    }
}
