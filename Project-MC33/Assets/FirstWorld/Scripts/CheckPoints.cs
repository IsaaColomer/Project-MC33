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
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        restartPos2 = startPos2;
        chRb = gameObject.GetComponent<Rigidbody2D>();
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
            posPlayer = new Vector2(chRb.transform.position.x, chRb.transform.position.y);
            spriteRenderer.sprite = newSprite;
        }
    }
        // Start is called before the first frame update
    public void LoadGameSaved()
    {
        GameObject pos03 = GameObject.Find("PlayerGeneral");
        FallRestart pos04 = pos03.GetComponent<FallRestart>();
        pos04.startPos = posPlayer;

        SceneManager.LoadScene("Lvl1");

    }
}
