using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fps : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        Debug.Log("Fps = 60");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
