using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyAudio : MonoBehaviour
{
    // Start is called before the first frame update
    public static DontDestroyAudio musicManagerInstance;
    void Start()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        Scene level = SceneManager.GetActiveScene();
        string levelName = level.name;
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
}
