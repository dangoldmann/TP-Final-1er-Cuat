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
        }
    }
}
