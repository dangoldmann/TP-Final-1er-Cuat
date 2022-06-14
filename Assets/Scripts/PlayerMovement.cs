using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public EndGameManager endGameManager;

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(0, 0, 0);

        float movementSpeed = 0.5f;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= -7)
        {
            transform.Translate(-movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) && transform.position.x <= 7)
        {
            transform.position += new Vector3(movementSpeed, 0, 0);
        }

        if(transform.position.y < -110)
        {
            endGameManager.EndGame(false);
        }
    }

}
