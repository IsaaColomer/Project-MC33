using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoColorBlock : MonoBehaviour
{
    public Collider2D breakCol;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public Sprite oldSprite;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        breakCol.enabled = false;
    }
    public void Update()
    {
        GameObject p = GameObject.Find("PlayerGeneral");
        FallRestart g = p.GetComponent<FallRestart>();
        if(g.dead)
        {
            Debug.Log("Reaches the Update function in NoColorBlock script");
            breakCol.enabled = false;
            spriteRenderer.sprite = oldSprite;
        }
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.layer == LayerMask.NameToLayer("Bullet"))
        {
            breakCol.enabled = true;
            spriteRenderer.sprite = newSprite;
        }
    }
}
