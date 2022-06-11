using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource source;
    public AudioClip impactoPlataforma;
    public AudioClip victoria;
    public AudioClip derrota;

    public void PlayPlatformImpactSound()
    {
        source.Stop();
        source.clip = impactoPlataforma;
        source.Play();
    }

    public void PlayVictorySound()
    {
        source.clip = victoria;
        source.Play();
    }

    public void PlayLossSound()
    {
        source.Stop();
        source.clip = derrota;
        source.Play();
    }
}
