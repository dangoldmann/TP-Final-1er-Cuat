using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    public Vector3 playerOldPosition = new Vector3(0, 0, 0);
    public static float YDestino;

    void Start()
    {
        YDestino = 13;   
    }

    void Update()
    {
        SeguirObjeto();
        //transform.position = new Vector3(0, player.transform.position.y + 7, -25); 
    }

    void SeguirObjeto()
    {
        int speed = 30;

        var step = speed * Time.deltaTime;

        Vector3 posicionDestino = new Vector3(0, YDestino, -25);
        
        transform.position = Vector3.MoveTowards(transform.position, posicionDestino, step);
    }
}
