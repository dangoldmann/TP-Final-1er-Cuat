using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Camera camera;
    Rigidbody rb; 
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(0, 0, 0);

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
        switch (col.gameObject.name)
        {
            case "Platform":
                Debug.Log("Colision");
                rb.AddForce(Vector3.up * 20, ForceMode.Impulse);
                break;
            case "FinalPlatform":
                Debug.Log("Ganaste");
                break;
            case "Sensor1":
                Debug.Log("Sensor1");
                break;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        switch (col.gameObject.name)
        {
            //case "Sensor1":
            //    Debug.Log("Sensor1");
            //    ChangeCameraView(0);
            //    break;
            //case "Sensor2":
            //    Debug.Log("Sensor2");
            //    ChangeCameraView(-10);
            //    break;
            //case "Sensor3":
            //    Debug.Log("Sensor3");
            //    ChangeCameraView(-20);
            //    break;
            //case "Sensor4":
            //    Debug.Log("Sensor4");
            //    ChangeCameraView(-30);
            //    break;
            //case "Sensor5":
            //    Debug.Log("Sensor5");
            //    ChangeCameraView(-40);
            //    break;
        }
    }

    void ChangeCameraView(float YPos)
    {
        camera.transform.position = new Vector3(0, YPos, -25);
    }
}
