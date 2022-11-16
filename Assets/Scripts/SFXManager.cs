using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    //clip de audio para la muerte de rock
    public AudioClip bombSFX;
    //clip de audio para musica de victori
    public AudioClip estrellaSFX;
    
    private AudioSource _audioSource;

    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }


    public void BombExlpode()
    {
        _audioSource.PlayOneShot(bombSFX);
    }

    public void Estrella()
    {
        _audioSource.PlayOneShot(estrellaSFX);
    }
}
