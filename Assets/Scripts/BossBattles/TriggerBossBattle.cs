using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBossBattle : MonoBehaviour
{
    public Animator animator;
    public GameObject door;
    private Vector3 doorRotation;
    public PlayAudioOnTrigger audioPlayer;
    public AudioClip mainTheme;

    private bool bossBattleTriggered = false;
    private void OnTriggerEnter(Collider collider)
    {
        if(bossBattleTriggered)
        {
            return;
        }

        if(collider.GetComponent<PlayerController>())
        {
            CloseDoor();

            audioPlayer.PlayAudioForBoss();
            audioPlayer.canTrigger = false;
        }
    }

    public void CloseDoor()
    {
        doorRotation = door.transform.eulerAngles;
        door.transform.eulerAngles = Vector3.zero;
    }

    public void OpenDoor()
    {
        door.transform.eulerAngles = doorRotation;
        AudioSource source = Camera.main.GetComponent<AudioSource>();
        source.Stop();
        source.clip = mainTheme;
        source.Play();
    }


}
