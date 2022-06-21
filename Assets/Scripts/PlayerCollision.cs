using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    Rigidbody rb;
    public AudioManager audioManager;
    public EndGameManager endGame;
    public TimeManager timeManager;
    public PlatformsHitManager platformsHitManager;

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
                //float platformNumber = col.gameObject.transform.position.y / (-10) + 1;
                //platformsHitManager.CountPlatformHit(platformNumber);
                break;
            case "DeathPlatform":
                endGame.EndGame(false);
                break;
            case "FinalPlatform(Clone)":
                endGame.EndGame(true);
                break;
            
        }
    }

    void OnTriggerEnter(Collider col)
    {
        int coinNumber = int.Parse(col.gameObject.name[6].ToString());
        Debug.Log(coinNumber);
        Destroy(col.gameObject);
        switch (col.gameObject.name)
        {
            case "Moneda0":
                platformsHitManager.CountPlatformHit(0);
                break;
            case "Moneda0":
                platformsHitManager.CountPlatformHit(0);
                break;
            case "Moneda0":
                platformsHitManager.CountPlatformHit(0);
                break;
        }
        platformsHitManager.CountPlatformHit(coinNumber);
    }

    void Bounce()
    {
        audioManager.PlayPlatformImpactSound();
        rb.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }
}
