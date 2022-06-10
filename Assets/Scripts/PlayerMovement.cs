using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject secondaryCamera;
    
    public Text txtResultado;
    public GameObject restartButton;

    Rigidbody rb; 
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        restartButton.SetActive(false);
        secondaryCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(0, 0, 0);

        

        Movement();
    }

    void Movement()
    {
        float movementSpeed = 0.5f;
        if (Input.GetKey(KeyCode.A) && transform.position.x >= -7)
        {
            transform.Translate(-movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D) && transform.position.x <= 7)
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
                EndGame(false);
                break;
            case "FinalPlatform":
                EndGame(true);
                break;
        }
    }

    void ShowResult(bool victoria)
    {
        txtResultado.text = victoria ? "Ganaste" : "Perdiste";
    }
    
    void EndGame(bool victoria)
    {
        ShowResult(victoria);
        secondaryCamera.SetActive(true);
        restartButton.SetActive(true);

        TimeManager timeManager = new TimeManager();
        timeManager.CheckBestScore();
    }

    #region CHANGE CAMERA VIEW
    void OnTriggerEnter(Collider col)
    {
        switch (col.gameObject.name)
        {
            case "Sensor1":
                Debug.Log("Sensor1");
                ChangeCameraView(0);
                break;
            case "Sensor2":
                Debug.Log("Sensor2");
                ChangeCameraView(-10);
                break;
            case "Sensor3":
                Debug.Log("Sensor3");
                ChangeCameraView(-20);
                break;
            case "Sensor4":
                Debug.Log("Sensor4");
                ChangeCameraView(-30);
                break;
            case "Sensor5":
                Debug.Log("Sensor5");
                ChangeCameraView(-40);
                break;
        }
    }

    void ChangeCameraView(int YPOS)
    {
        //camera.transform.position = new Vector3(0, YPOS, -25);
    }
    #endregion

}
