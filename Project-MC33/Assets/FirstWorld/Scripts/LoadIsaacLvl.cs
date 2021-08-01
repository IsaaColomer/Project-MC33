using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadIsaacLvl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        void OnTriggerExit2D(Collider2D coll)
    {
        if(coll.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            SceneManager.LoadScene("Isaac");
        }
    }
}
