using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text txtTime;

    float elapsedTime = 0;
    
    public static bool isPlaying;
    
    // Start is called before the first frame update
    void Start()
    {
        isPlaying = true;
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime = Time.timeSinceLevelLoad;
        if (isPlaying)
            txtTime.text = elapsedTime.ToString("N3");
    }

    public float GetLastTime()
    {
        return elapsedTime;
    }
}
