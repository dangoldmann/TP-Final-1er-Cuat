using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text txtBestScore;
    public Text txtTime;

    float bestScore = 0;
    float elapsedTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime = Time.time;
        elapsedTime = Mathf.Floor(elapsedTime);
        txtTime.text = $"Time:     {elapsedTime}";
    }

    public void CheckBestScore()
    {
        if (elapsedTime < bestScore)
        {
            bestScore = elapsedTime;
        }

        Debug.Log($"Best score: {bestScore}");
        Debug.Log(txtBestScore);
        txtBestScore.text = $"Best score: {bestScore}";
    }
}
