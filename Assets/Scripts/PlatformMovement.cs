using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    bool ToRight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 0.2f;
        if (ToRight)
        {
            transform.position += new Vector3(speed, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(speed, 0, 0);
        }

        if(transform.position.x >= 7)
        {
            ToRight = false;
        }
        else if (transform.position.x <= -7)
        {
            ToRight = true;
        }
    }
}
