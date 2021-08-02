using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlayer : MonoBehaviour
{
    public GameObject Player;
    public GameObject spawnLocation;
    // Start is called before the first frame update
    void Awake()
    {
        // if(GameObject.FindGameObjectWithTag("Player") != null)
        // {
        //     Player = GameObject.FindGameObjectWithTag("Player");
        //     GameObject posF = GameObject.Find("PlayerGeneral");
        //     FallRestart posF1 = posF.GetComponent<FallRestart>();

        //     Player.transform.position = posF1.startPos;
        // }
        // else
        // {
        //     Debug.Log("NO PLAYER!!!");
        // }
            
        
    }
}
