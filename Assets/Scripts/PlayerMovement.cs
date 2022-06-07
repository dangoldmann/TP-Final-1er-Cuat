using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Text txtResultado;
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
        if (Input.GetKey(KeyCode.A) && transform.position.x > -9)
        {
            transform.Translate(-movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D) && transform.position.x < 9)
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
            case "DeathPlatform":
                ShowResult(false);
                break;
            case "FinalPlatform":
                ShowResult(true);
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
            //    camera.transform.position = new Vector3(0, 0, -25);
            //    break;
            //case "Sensor2":
            //    Debug.Log("Sensor2");
            //    camera.transform.position = new Vector3(0, -10, -25);
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

    void ShowResult(bool victoria)
    {
        Debug.Log(victoria);
        txtResultado.text = victoria ? "Ganaste" : "Perdiste";
    }
    
}
