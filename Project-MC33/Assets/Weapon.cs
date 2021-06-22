using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour,IPooledObject
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public int bulletCount = 0;
    ObjectPooler objectPooler;

    public void Start()
    {
        objectPooler = ObjectPooler.Instance;
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("x"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        if(bulletCount < 6)
        {
            objectPooler.SpawnFromPool("Bullet", transform.position, Quaternion.identity);
            bulletCount++;
        }      
    }
}
