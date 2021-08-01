using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoints : MonoBehaviour
{
    public Vector3 startPos2;
    public Vector3 restartPos2;
    public Rigidbody2D chRb;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        restartPos2 = startPos2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            GameObject pos01 = GameObject.Find("PlayerGeneral");
            FallRestart pos02 = pos01.GetComponent<FallRestart>();
            pos02.startPos = chRb.transform.position;
            spriteRenderer.sprite = newSprite;
        }
    }
}
