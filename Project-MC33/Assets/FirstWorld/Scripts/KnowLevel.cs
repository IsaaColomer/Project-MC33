using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KnowLevel : MonoBehaviour
{
    public int level;
    string sceneName;
    public int lvl;
    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene ();
        sceneName = currentScene.name;
    }

    // Update is called once per frame
    void Update()
    {
        if(sceneName != "StartMenu" && sceneName != "Options")
        {
            if(sceneName == "Lvl1")
            {
                level = 1;
            }
            if(sceneName == "Isaac")
            {
                level = 2;
            }
        }

    }
}
