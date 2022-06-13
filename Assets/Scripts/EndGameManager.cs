using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameManager : MonoBehaviour
{
    public GameObject panel;
    public Text txtTime;
    public Text txtResultado;
    public GameObject secondaryCamera;
    public GameObject restartButton;
    public GameObject player;
    public TimeManager timeManager;
    public BestScoreManager bestScoreManager;
    public AudioManager audioManager;

    public void EndGame(bool victoria)
    {
        secondaryCamera.SetActive(true);
        restartButton.SetActive(true);
        panel.SetActive(true);

        TimeManager.isPlaying = false;

        if (victoria && PlatformsHitManager.allPlatformsHit)
        {
            player.SetActive(false);
            audioManager.PlayVictorySound();
            bestScoreManager.CheckBestScore(timeManager.GetLastTime());
            txtResultado.text = "Ganaste";
        }
        else
        {
            player.SetActive(false);
            audioManager.PlayLossSound();
            txtResultado.text = "Perdiste";
            txtTime.text = "-";
        }
    }
}
