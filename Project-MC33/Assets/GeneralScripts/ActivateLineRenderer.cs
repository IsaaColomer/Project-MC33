using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ActivateLineRenderer : MonoBehaviour
{
    public bool draw;
    public LineRenderer renderer;
    public GameObject player;
    public Vector2 grapPosO;
    public Vector2 grapPos;
    // Start is called before the first frame update
    // Update is called once per frame
    public void Start()
    {
        draw = false;
    }
    void Update()
    {
        renderer = gameObject.GetComponent<LineRenderer>();
    }
    void OnTriggerStay2D(Collider2D col)
    {
        if(col.gameObject.layer == LayerMask.NameToLayer("Grap"))
        {
            grapPosO = col.transform.position;
            grapPos = grapPosO;
            draw = true;
            Debug.Log("New line");
            
            renderer.SetPosition(0, grapPos);
            renderer.SetPosition(1, player.transform.position);
            renderer.enabled = true;
            
        }
        else
        {
            draw = false;
            renderer.enabled = false;
        }
    }
}
