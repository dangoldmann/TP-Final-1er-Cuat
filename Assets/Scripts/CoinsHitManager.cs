using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsHitManager : MonoBehaviour
{
    public Text txtCoinsHit;
    public static bool allCoinsHit = false;
    int coinsHit = 0;

    public void CountCoinHit()
    {
        coinsHit++;
        txtCoinsHit.text = $"{coinsHit} / 10";
        allCoinsHit = coinsHit == 10;
    }
}
