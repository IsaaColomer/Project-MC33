using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapSprites : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;

    public void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite; 
    }
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.layer == LayerMask.NameToLayer("Bullet"))
        {
            ChangeSprite();
        }
    }
}
