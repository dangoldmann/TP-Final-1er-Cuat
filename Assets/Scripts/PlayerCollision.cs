using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    Rigidbody rb;
    public AudioManager audioManager;
    public EndGame endGame;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        switch (col.gameObject.name)
        {
            case "Platform":
                rb.AddForce(Vector3.up * 20, ForceMode.Impulse);
                audioManager.PlayPlatformImpactSound();
                break;
            case "DeathPlatform":
                endGame.Fin(false);
                break;
            case "FinalPlatform":
                endGame.Fin(true);
                break;
        }
    }
}
