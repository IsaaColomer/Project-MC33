using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkEnemySpawn : MonoBehaviour
{
    public float timeUntilNewSpawn;
    public bool spawn = false; 
    public Transform walkEnemy;
    public Transform spawnPoint;
    public float randomX;
    public float randomY;
    public float max = 15;
    public float min = 0;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        randomX = Random.Range(min,max); 
        randomY = Random.Range(min,max); 

        if(randomX < min || randomX > max)
        {
            randomX = Random.Range(min,max); 
        }

        if(randomY < min || randomY > max)
        {
            randomY = Random.Range(min,max); 
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
            Instantiate(walkEnemy, new Vector3(spawnPoint.transform.position.x+randomX, spawnPoint.transform.position.y+randomY, 0f) , transform.rotation);
            timeUntilNewSpawn = 5f;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        
    }
}
