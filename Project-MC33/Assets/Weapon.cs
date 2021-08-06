using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public int bulletCount = 0;
    // Start is called before the first frame update
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
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            bulletCount++;
        }
    }
}
