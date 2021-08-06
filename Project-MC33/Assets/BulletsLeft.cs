using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletsLeft : MonoBehaviour
{
    public SpriteRenderer[] newSprite = new SpriteRenderer[6];
    public int totalBulletsOnScreen = 0;
    public GameObject[] bulletsObj = new GameObject[6];

    // Start is called before the first frame update
    void Start()
    {

        
    }
    // Update is called once per frame
    void Update()
    {
        GameObject count = GameObject.Find("PlayerGeneral");
        Weapon count2 = count.GetComponent<Weapon>();
        
        if(count2.bulletCount == 0)
        {
            newSprite[0].enabled = true;
            newSprite[1].enabled = true;
            newSprite[2].enabled = true;
            newSprite[3].enabled = true;
            newSprite[4].enabled = true;
            newSprite[5].enabled = true;
        }
        else if(count2.bulletCount == 1)
        {
            newSprite[0].enabled = false;
            newSprite[1].enabled = true;
            newSprite[2].enabled = true;
            newSprite[3].enabled = true;
            newSprite[4].enabled = true;
            newSprite[5].enabled = true;
        }
        else if(count2.bulletCount == 2)
        {
            newSprite[0].enabled = false;
            newSprite[1].enabled = false;
            newSprite[2].enabled = true;
            newSprite[3].enabled = true;
            newSprite[4].enabled = true;
            newSprite[5].enabled = true;
        }
        else if(count2.bulletCount == 3)
        {
            newSprite[0].enabled = false;
            newSprite[1].enabled = false;
            newSprite[2].enabled = false;
            newSprite[3].enabled = true;
            newSprite[4].enabled = true;
            newSprite[5].enabled = true;
        }
        else if(count2.bulletCount == 4)
        {
            newSprite[0].enabled = false;
            newSprite[1].enabled = false;
            newSprite[2].enabled = false;
            newSprite[3].enabled = false;
            newSprite[4].enabled = true;
            newSprite[5].enabled = true;
        }
        else if(count2.bulletCount == 5)
        {
            newSprite[0].enabled = false;
            newSprite[1].enabled = false;
            newSprite[2].enabled = false;
            newSprite[3].enabled = false;
            newSprite[4].enabled = false;
            newSprite[5].enabled = true;
        }
        else if(count2.bulletCount == 6)
        {
            newSprite[0].enabled = false;
            newSprite[1].enabled = false;
            newSprite[2].enabled = false;
            newSprite[3].enabled = false;
            newSprite[4].enabled = false;
            newSprite[5].enabled = false;
        }
    }
}
