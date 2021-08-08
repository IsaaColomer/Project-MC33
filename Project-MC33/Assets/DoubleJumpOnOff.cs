using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJumpOnOff : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public Sprite oldSprite;
    public bool spriteDoubleJump;
    public void Start()
    {
        spriteRenderer.sprite = oldSprite;
    }
    void Update()
    {
        if(spriteDoubleJump == false)
        {
            spriteRenderer.sprite=newSprite;
        }
        if(spriteDoubleJump)
        {
            spriteRenderer.sprite = oldSprite;
        }
    }
}
