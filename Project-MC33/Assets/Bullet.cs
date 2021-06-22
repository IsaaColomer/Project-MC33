using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    //public GameObject bp;
    private GameObject bc;

    // Start is called before the first frame update
    void OnObjectSpawn()
    {
       rb.velocity = transform.right * speed;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.layer == LayerMask.NameToLayer("DestroyBullet"))
        {
            Debug.Log("Destroy");
            Destroy(this);
        }
    }
}
//if (GameObject.FindGameObjectsWithTag(tag).Length < 5) {        boltObject = (GameObject)Instantiate (bolt, Canon.position, Canon.rotation);      boltObject.tag = tag;    }