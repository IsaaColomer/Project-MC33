using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyAudio : MonoBehaviour
{
    // Start is called before the first frame update
    public static DontDestroyAudio musicManagerInstance;
    public AudioClip songMenu;
    public AudioClip songGame;
    void Start()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        Scene level = SceneManager.GetActiveScene();
        string levelName = level.name;
        if(level.name == "Lvl1" || level.name == "Options")
        {
            DontDestroyOnLoad(this);
            if(musicManagerInstance == null)
            {
                musicManagerInstance = this;
            }
            else
            {
                Destroy(gameObject);
            }
            audioSource.Play();
        }
        else
        {
            Debug.Log("Music Menu");
            audioSource.Stop();
            Destroy(this);
            //songGame.Stop();
        }
    }
}
