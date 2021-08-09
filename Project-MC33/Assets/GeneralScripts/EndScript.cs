using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour
{
    public ParticleSystem end;
    public float time;
    private float seconds;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            end.Play();
        }
    }
    public void OnTriggerStay2D(Collider2D col)
    {
            time += Time.deltaTime;
        seconds = time % 60;//Use the euclidean division for the seconds.
        if(seconds >= 7)
        {
            SceneManager.LoadScene("Thx");
            time = 0;
        }
    }
}
