using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSpriteBy : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
        
    }

    // Update is called once per frame
        void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            spriteRenderer.enabled = true;
        }
        
    }
}
