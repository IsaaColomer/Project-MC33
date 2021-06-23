using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    private Rigidbody2D player;
    public GameObject playerO;
    public Vector3 savedPosition;
    public bool boxHitted = false;

    Weapon count;
    void Start()
    {
       player = playerO.GetComponent<Rigidbody2D>();
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
        if(col.gameObject.layer == LayerMask.NameToLayer("Box"))
        {
            GameObject playerNowPos = GameObject.Find("PlayerGeneral");
            FallRestart playerNowPos2 = count.GetComponent<FallRestart>();

            playerNowPos2.startPos = player.transform.position;
            boxHitted = true;
            Debug.Log("Box Detected!");
            Destroy(gameObject);
            count2.bulletCount--;
        }
    }
}
//if (GameObject.FindGameObjectsWithTag(tag).Length < 5) {        boltObject = (GameObject)Instantiate (bolt, Canon.position, Canon.rotation);      boltObject.tag = tag;    }