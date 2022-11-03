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
            //‰¹(sound1)‚ð–Â‚ç‚·
            audioSource.PlayOneShot(sound1);   
    }
}