using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    Weapon count;
    void Start()
    {
       rb.velocity = transform.right * speed;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        GameObject count = GameObject.Find("PlayerGeneral");
        Weapon count2 = count.GetComponent<Weapon>();
        if(col.gameObject.layer == LayerMask.NameToLayer("DestroyBullet"))
        {
            Destroy(gameObject);
            count2.bulletCount--;
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        GameObject count = GameObject.Find("PlayerGeneral");
        Weapon count2 = count.GetComponent<Weapon>();
        if(col.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            Destroy(gameObject);
            count2.bulletCount--;
        }
    }
}
//if (GameObject.FindGameObjectsWithTag(tag).Length < 5) {        boltObject = (GameObject)Instantiate (bolt, Canon.position, Canon.rotation);      boltObject.tag = tag;    }