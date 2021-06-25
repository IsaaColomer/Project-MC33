using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1 : MonoBehaviour
{
    public int life = 50;
    public Transform firePoint;
    public GameObject bulletPrefab;
    MovementFirst target;
    public Rigidbody2D rb;
    public GameObject player;
    public Vector2 moveDir;
    public float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        moveDir = (player.transform.position-transform.position).normalized;
        if(life == 0)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            Instantiate(bulletPrefab, moveDir, firePoint.rotation);
        }
    }
}
