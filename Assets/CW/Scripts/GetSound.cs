using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSound : MonoBehaviour
{
    public AudioClip SFX;
    private AudioSource music;

    public static GetSound instance;

    private void Awake()
    {
        if (GetSound.instance == null)
            GetSound.instance = this;
    }
    void Start()
    {
        music = GetComponent<AudioSource>();
    }

    public void playSound()
    {
        music.PlayOneShot(SFX);
    }

}