using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CheckPoints : MonoBehaviour
{
    public Vector3 startPos2;
    public Vector3 restartPos2;
    public Rigidbody2D chRb;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public Vector2 posPlayer;

    public static int allChecks = 8;
    public bool saved;
    public int currentCheck = 0;
    public bool contact;
    // Start is called before the first frame update
    void Start()
    {
        contact = false;
        
        saved = false;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        restartPos2 = startPos2;
        chRb = gameObject.GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            contact = true;
            saved = true;

            GameObject pos01 = GameObject.Find("PlayerGeneral");
            FallRestart pos02 = pos01.GetComponent<FallRestart>();
            pos02.startPos = chRb.transform.position;

            posPlayer = new Vector2(chRb.transform.position.x, chRb.transform.position.y);
            spriteRenderer.sprite = newSprite;
            
        }
    }
}
