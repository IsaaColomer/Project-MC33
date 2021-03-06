using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
    public float time;
    public GameObject platform;
    public SpriteRenderer me;
    public Collider2D breakCol;
    // Start is called before the first frame update
    void Start()
    {
        time = 1f;
        breakCol = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject grap = GameObject.Find("PlayerGeneral");
        FallRestart grap2 = grap.GetComponent<FallRestart>();

        if(grap2.dead == true)
        {
            me.color = new Color(1f,1f,1f,1f);
            breakCol.enabled = true;
            time = 1f;
        }

    }
    void OnCollisionStay2D(Collision2D col)
    {
        me.color = new Color(1f,1f,1f,time);
        if(time <= 0)
        {
            breakCol.enabled = !breakCol.enabled;
        }

        if(col.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            Debug.Log("PlayerOnPlatform");
            time -= Time.deltaTime;
        }
        Debug.LogFormat("Time: {0}", time);
    }
}
