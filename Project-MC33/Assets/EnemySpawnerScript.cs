using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public float timeUntilNewSpawn = 2f;
    public bool spawn = false; 
    public Transform enemy;
    public float randomX;
    public float randomY;
    public float max = 10;
    public float min = -10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        randomX = Random.Range(-10,10); 
        randomY = Random.Range(-10,10); 

        if(randomX < min || randomX > max)
        {
            randomX = Random.Range(-10,10); 
        }

        if(randomY < min || randomY > max)
        {
            randomY = Random.Range(-10,10); 
        }
        if(timeUntilNewSpawn>0f)
        {
            timeUntilNewSpawn -= Time.deltaTime;
            spawn = false;
        }
        else
        {
            spawn = true;
        }  

        
    }
    void OnTriggerStay2D(Collider2D col)
    {            
         
        if(col.gameObject.layer == LayerMask.NameToLayer("Player") && spawn == true)
        {
            Instantiate(enemy, new Vector3(transform.position.x+randomX, transform.position.y+randomY, 0f) , transform.rotation);
            timeUntilNewSpawn = 2f;
        }
    }
}
