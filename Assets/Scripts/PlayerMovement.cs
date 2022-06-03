using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movementSpeed = 0.5f;
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(movementSpeed, 0, 0);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Platform")
        {
            //transform.position += new Vector3(0, 5, 0);
        }
        else if (col.gameObject.name == "FinalPlatform")
        {
            Debug.Log("Ganaste");
        }
    }
}
