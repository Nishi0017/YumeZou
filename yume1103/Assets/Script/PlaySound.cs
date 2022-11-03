using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{

    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySE(AudioClip sound1)
    {
            //��(sound1)��炷
            audioSource.PlayOneShot(sound1);   
    }
}