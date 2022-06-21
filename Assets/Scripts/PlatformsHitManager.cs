using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformsHitManager : MonoBehaviour
{
    public Text txtPlatformsHit;
    int[] platformsHit = new int[10];
    public static bool allPlatformsHit = false;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            platformsHit[i] = 0;
        }
    }

    public void CountPlatformHit(float platformNumber)
    {
        switch (platformNumber)
        {
            case 0:
                platformsHit[0] = 1;
                UpdateTxtPlatformsHit();
                break;
            case 1:
                platformsHit[1] = 1;
                UpdateTxtPlatformsHit();
                break;
            case 2:
                platformsHit[2] = 1;
                UpdateTxtPlatformsHit();
                break;
            case 3:
                platformsHit[3] = 1;
                UpdateTxtPlatformsHit();
                break;
            case 4:
                platformsHit[4] = 1;
                UpdateTxtPlatformsHit();
                break;
            case 5:
                platformsHit[5] = 1;
                UpdateTxtPlatformsHit();
                break;
            case 6:
                platformsHit[6] = 1;
                UpdateTxtPlatformsHit();
                break;
            case 7:
                platformsHit[7] = 1;
                UpdateTxtPlatformsHit();
                break;
            case 8:
                platformsHit[8] = 1;
                UpdateTxtPlatformsHit();
                break;
            case 9:
                platformsHit[9] = 1;
                UpdateTxtPlatformsHit();
                break;
        }
    }

    void UpdateTxtPlatformsHit()
    {
        int totalPlatformsHit = 0;

        for (int i = 0; i < 10; i++)
        {
            if (platformsHit[i] == 1)
            {
                totalPlatformsHit++;
            }
        }

        txtPlatformsHit.text = $"{totalPlatformsHit}/10";


        allPlatformsHit = totalPlatformsHit == 10;
        
    }
}
