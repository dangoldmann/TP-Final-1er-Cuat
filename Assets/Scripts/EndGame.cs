using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public Text txtResultado;
    public GameObject secondaryCamera;
    public GameObject restartButton;
    public TimeManager timeManager;

    // Start is called before the first frame update
    void Start()
    {
        secondaryCamera.SetActive(false);
        restartButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fin(bool victoria)
    {
        txtResultado.text = victoria ? "Ganaste" : "Perdiste";
        secondaryCamera.SetActive(true);
        restartButton.SetActive(true);

        timeManager.CheckBestScore();
    }
}
