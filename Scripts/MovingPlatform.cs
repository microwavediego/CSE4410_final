using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    // where the platform will go; editable in inspector 
    public Vector3 finishPos = Vector3.zero;

    // how fast the platform will move
    public float speed = 0.5f;

    // starting poing of the platform is where the platform is in the scene
    private Vector3 startPos;

    // percentage of completion (from 0.0 to 1.0) from start to finish 
    private float trackPercent = 0;

    // current movement direction 
    private int direction = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        // get starting position
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // interpolate new location between start and finish 
        trackPercent += direction * speed * Time.deltaTime;
        float x = (finishPos.x - startPos.x) * trackPercent + startPos.x;
        float y = (finishPos.y - startPos.y) * trackPercent + startPos.y;
        transform.position = new Vector3(x, y, startPos.z);

        // reverse direction at start/finish positions 
        if((direction == 1 && trackPercent > 0.9f) || (direction == -1 && trackPercent < 0.1f))
        {
            direction *= -1;
        }

        /*
        MovingPlatform platform = null;
        if (hit != null)
        {
            platform = hit.GetComponent<MovingPlatform>();
        }
        if (platform != null){
            transform.parent = platform.transform;
        } else
        {
            transform.parent = null;
        }
        */
    }
}
