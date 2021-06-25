using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    void Start()
    {
       rb.velocity = transform.right * speed;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        GameObject count = GameObject.Find("PlayerGeneral");
        Weapon count2 = count.GetComponent<Weapon>();

        GameObject bossLife = GameObject.Find("Boss");
        Boss1 bossLife2 = bossLife.GetComponent<Boss1>();

        if(col.gameObject.layer == LayerMask.NameToLayer("DestroyBullet"))
        {
            Debug.Log("Wall bullet destroyer Detected!");
            Destroy(gameObject);
            count2.bulletCount--;
        }
        if(col.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            Debug.Log("Ground Detected!");
            Destroy(gameObject);
            count2.bulletCount--;
        }
        if(col.gameObject.layer == LayerMask.NameToLayer("Spikes"))
        {
            Debug.Log("Spike Detected!");
            Destroy(gameObject);
            count2.bulletCount--;
        }
        if(col.gameObject.layer == LayerMask.NameToLayer("Boss"))
        {
            if(col.GetComponent<Collider>().GetType() == typeof(CircleCollider2D))
            {
             Debug.Log("Boss Circle Detected!");
            }
            else
            {
            Debug.Log("Boss Detected!");
            //Destroy(gameObject);
            count2.bulletCount--;
            bossLife2.life--;
            }
        }
        if(col.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            Debug.Log("Player Detected!");
            Destroy(gameObject);
            count2.bulletCount--;
        }
    }
}
//if (GameObject.FindGameObjectsWithTag(tag).Length < 5) {        boltObject = (GameObject)Instantiate (bolt, Canon.position, Canon.rotation);      boltObject.tag = tag;    }