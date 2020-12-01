using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip BFX;
    private AudioSource music;

    void Start()
    {
        music = GetComponent<AudioSource>();
        playSound(BFX, music);
    }

    public static void playSound(AudioClip clip, AudioSource audio)
    {
        audio.Stop();
        audio.clip = clip;
        audio.loop = true;
        audio.time = 0;
        audio.Play();
    }
}
