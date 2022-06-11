using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameManager : MonoBehaviour
{
    public GameObject secondaryCamera;
    public GameObject restartButton;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        secondaryCamera.SetActive(false);
        restartButton.SetActive(false);
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
