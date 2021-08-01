using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        sprite = gameObject.GetComponent<SpriteRenderer>();
        sprite.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            sprite.enabled = true;
        }
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        if(coll.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            sprite.enabled = false;
        }
    }
}
