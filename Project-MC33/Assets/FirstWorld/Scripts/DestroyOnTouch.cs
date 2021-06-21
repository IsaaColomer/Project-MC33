using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class DestroyOnTouch : MonoBehaviour
{
    public GameObject doubleJamp;
    // Start is called before the first frame update
    void Start()
    {
        doubleJamp.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  void OnTriggerEnter2D(Collider2D col)
    {
        //Detecting the Grid Position of Player
        
        doubleJamp.SetActive(false); 
    }
}
