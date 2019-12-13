using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;


    void Awake() {
        
        foreach (Sound currentSound in sounds) {
            
            currentSound.source = gameObject.AddComponent<AudioSource>();

            currentSound.source.clip = currentSound.soundClip;
            currentSound.source.volume = currentSound.volume;
            currentSound.source.pitch = currentSound.pitch;
            currentSound.source.loop = currentSound.isLoop;

        }

    }

    public void Play(string soundToBePlayed) {

        Sound currentSound = Array.Find(sounds, sound => sound.name == soundToBePlayed);
        currentSound.source.Play();
    }

    void Start()
    {
        Play("BackgroundMusic");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
