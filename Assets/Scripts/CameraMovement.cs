using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    public int YPOS;
    public static Vector3 posicionDestino;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SeguirObjeto();
        //transform.position = new Vector3(0, player.transform.position.y + 7, -25);   
    }

    void SeguirObjeto()
    {
        int speed = 10;

        Vector3 posicionDestino = new Vector3(0, 5, -25);

        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, posicionDestino, step);
    }
}
