using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJumpReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name == "Grap(8)")
        {
            GameObject pol = GameObject.Find("PlayerGeneral");
            MovementFirst pol2 = pol.GetComponent<MovementFirst>();

            pol2.doubleJump = true;
            Debug.Log("pitito");
        }        
    }
}
