using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    public CoinsHitManager coinsHitManager;

    void OnTriggerEnter(Collider col)
    {
        switch (col.gameObject.name)
        {
            case "Moneda":
                Destroy(col.gameObject);
                coinsHitManager.CountCoinHit();
                break;
            case "Sensor":
                Destroy(col.gameObject);
                CameraMovement.YDestino -= 10;
                break;
        }
    }
}
