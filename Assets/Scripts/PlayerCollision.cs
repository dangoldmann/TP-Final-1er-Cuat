using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    Rigidbody rb;
    public AudioManager audioManager;
    public EndGameManager endGame;
    public TimeManager timeManager;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision col)
    {
        switch (col.gameObject.name)
        {
            case "Platform":
                Bounce();
                break;
            case "DeathPlatform":
                endGame.EndGame(false);
                break;
            case "FinalPlatform":
                endGame.EndGame(true);
                break;
            
        }
    }

    void Bounce()
    {
        audioManager.PlayPlatformImpactSound();
        rb.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }
}
