using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigEnter : MonoBehaviour
{
    public int puntuation = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.layer == LayerMask.NameToLayer("Bullet"))
        {
            puntuation += 10;
        }
    }
}
