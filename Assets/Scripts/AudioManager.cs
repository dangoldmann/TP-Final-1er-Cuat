using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource source;
    public AudioClip impactoPlataforma;

    // Start is called before the first frame update
    void Start()
    {
        //source = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayPlatformImpactSound()
    {
        source.clip = impactoPlataforma;
        source.Play();
    }
}
