using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapDetection : MonoBehaviour
{
    public bool grapOn = false;
    public Camera mainCamera;
    public LineRenderer _lineRenderer;
    public DistanceJoint2D _distanceJoint;
    public Vector2 grapPosO;

    // Start is called before the first frame update
    void Start()
    {
        _distanceJoint.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("x") && grapOn == false)
        {
            grapOn = false;
        }
        if (Input.GetKeyDown("x") && grapOn == true)
        {
            Vector2 grapPos = grapPosO;
            _lineRenderer.SetPosition(0, grapPos);
            _lineRenderer.SetPosition(1, transform.position);
            _distanceJoint.connectedAnchor = grapPos;
            _distanceJoint.enabled = true;
            _lineRenderer.enabled = true;
        }
        else if (Input.GetKeyUp("x"))
        {
            _distanceJoint.enabled = false;
            _lineRenderer.enabled = false;
            grapOn = false;
        }
        if (_distanceJoint.enabled) 
        {
            _lineRenderer.SetPosition(1, transform.position);
        }
    }
    void OnTriggerStay2D(Collider2D col)
    {
        if(col.gameObject.layer == LayerMask.NameToLayer("Grap"))
        {
            Debug.Log("Grap!");
            grapPosO = col.transform.position;
            grapOn = true;
        }
        else
        {
            grapOn = false;
        }
    }
}
