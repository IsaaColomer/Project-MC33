using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class DestroyOnTouch : MonoBehaviour
{
    public GameObject doubleJamp;
    public Collider2D breakCol;
    public SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        //doubleJamp.SetActive(true);
        breakCol = GetComponent<Collider2D>();
        //breakCol.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject p = GameObject.Find("PlayerGeneral");
        FallRestart g = p.GetComponent<FallRestart>();
        if(g.dead == true)
        {
            breakCol.enabled = true;
            sprite.enabled = true;
        }
    }
    public void OnTriggerEnter2D(Collider2D col)
    {               
        if(col.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
        breakCol.enabled = false;
        sprite.enabled = false;
        }
    }
}