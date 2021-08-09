using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuation : MonoBehaviour
{    
    public Text puntLabel;
    public Bullet a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       puntLabel.text = a.GetComponent<Bullet>().Puntuation.ToString();
    }
}
