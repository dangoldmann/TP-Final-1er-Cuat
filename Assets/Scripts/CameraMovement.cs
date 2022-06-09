using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    public int YPOS;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posicionDestino = transform.position;
        posicionDestino.y = YPOS; 

        var step = 1 * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, posicionDestino, step);
        //transform.position = new Vector3(0, player.transform.position.y + 7, -25);   
    }
}
