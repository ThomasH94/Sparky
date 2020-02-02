using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnTrigger : MonoBehaviour
{
    public AudioClip clipToPlay;
    public bool canTrigger = true;

    void OnTriggerEnter(Collider collider)
    {
        if(!canTrigger)
        {
            return;
        }

        if(collider.GetComponent<PlayerController>())
        {
            Camera mainCamera = Camera.main;
            AudioSource source = mainCamera.GetComponent<AudioSource>();
            if(source.clip == null)
            {
                source.Stop();
                source.clip = clipToPlay;
                source.Play();
            }
            else if(source.clip.name != clipToPlay.name)
            {
                source.Stop();
                source.clip = clipToPlay;
                source.Play();
            }

        }
    }

    public void PlayAudioForBoss()
    {
        if(!canTrigger)
        {
            return;
        }
        Camera mainCamera = Camera.main;
        AudioSource source = mainCamera.GetComponent<AudioSource>();
        source.Stop();
        source.clip = clipToPlay;
        source.Play();
    }
}
