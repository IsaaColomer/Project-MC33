using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapImage : MonoBehaviour
{
    public SpriteRenderer sprite;
    // Update is called once per frame
    public void Update()
    {
        GameObject grap = GameObject.Find("PlayerGeneral");
        GrapDetection grap2 = grap.GetComponent<GrapDetection>();

        if(grap2.sprite01)
        {
            sprite.enabled = true;
        }
        else
        {
            sprite.enabled = false;
        }
        
    }

    public void OnMouseOver()
    {
        sprite.enabled = false;
    }
    public void OnMouseExit()
    {
        sprite.enabled = true;
    }
}
