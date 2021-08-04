using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadIsaacLvl : MonoBehaviour
{
    public GameObject player;
    void OnTriggerExit2D(Collider2D coll)
    {
        if(coll.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            Destroy(player);
            Debug.Log("Player Destroyed");
            SceneManager.LoadScene("Isaac");
        }
    }
}
