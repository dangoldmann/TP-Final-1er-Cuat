using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScoreManager : MonoBehaviour
{
    public Text txtBestScore;

    // Start is called before the first frame update
    void Start()
    {
        txtBestScore.text = $"Best score: {PlayerPrefs.GetFloat("BestScore"):N3}";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckBestScore(float lastTime)
    {
        if (lastTime < PlayerPrefs.GetFloat("BestScore") || PlayerPrefs.GetFloat("BestScore") == 0)
        {
            PlayerPrefs.SetFloat("BestScore", lastTime);

            txtBestScore.text = $"Best score: {lastTime:N3}";
        }

        
    }
}
