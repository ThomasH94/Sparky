using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script will be attached to any object that wants to play audio
/// </summary>
public class AudioPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClips;
    // We have a dictionary to prevent issues with calling any audio clips and fill it with our public audio clips
    public Dictionary<string, AudioClip> audioClipDictionary = new Dictionary<string, AudioClip>();

    private void Start()
    {
        // Populate our dictionary because they aren't serilizable..
        foreach(AudioClip clip in audioClips)
        {
            audioClipDictionary.Add(clip.name, clip);
        }
    }

    public void PlayAudioByString(string clipToPlay)
    {
        if(audioClipDictionary.ContainsKey(clipToPlay))
        {
            audioSource.clip = audioClipDictionary[clipToPlay];
            audioSource.Play();
        }
        else
        {
            Debug.Log("No audio clip found with the key: " + clipToPlay);
        }

    }

    public void StopAudio()
    {
        audioSource.Stop();
    }

    #region Fades
    public void FadeAudio()
    {

    }

    private IEnumerator FadeAudioRoutine()
    {
        yield return new WaitForSeconds(1.0f);
    }
    #endregion

}