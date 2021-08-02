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
        GameObject pos01 = GameObject.Find("KnowLvl");
        KnowLevel pos02 = pos01.GetComponent<KnowLevel>();
        
        SceneManager.LoadScene(pos02.level);
    }
}
