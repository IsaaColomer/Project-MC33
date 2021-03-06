using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int Puntuation;
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
        if(col.gameObject.layer == LayerMask.NameToLayer("Enemies"))
        {
            Debug.Log("Enemy Detected!");
            Destroy(gameObject);
            count2.bulletCount--;
        }
        if(col.gameObject.layer == LayerMask.NameToLayer("Aim"))
        {
            Puntuation += 10;
            SaveMangerDone.instance.activeSave.puntuationAims = Puntuation;
            Debug.Log("Aim Detected!");
            Destroy(gameObject);
            count2.bulletCount--;
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        GameObject s = GameObject.Find("PlayerGeneral");
        Weapon a = s.GetComponent<Weapon>();   
        if(col.gameObject.layer == LayerMask.NameToLayer("WalEnemy"))
        {
            Debug.Log("Walk Enemy Detected!");
            Destroy(gameObject);
            a.bulletCount--;
        }
    }
}