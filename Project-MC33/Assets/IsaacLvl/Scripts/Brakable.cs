using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brakable : MonoBehaviour
{
    public float currentTime = 0f;
    public float srtartingTime = 2f;
    public bool restart = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(restart == true)
        {
            gameObject.SetActive(true);
            restart = false;
        }
    }
    void OnCollisionStay2D(Collision2D col)
    {
        if(col.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            currentTime += 1* Time.deltaTime;
            if(currentTime > srtartingTime)
            {
                gameObject.SetActive(false);
                currentTime = srtartingTime;
            }
        }
    }
}
