using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JukeboxController : MonoBehaviour
{
    public string expectedRecordTag = "RecordTag"; // Set the tag of the correct record.
    public AudioClip soundToPlay; // The sound to play when the correct record is placed.

    private bool isAudioPlaying = false; // Flag to control audio playback.

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(expectedRecordTag))
        {
            if (!isAudioPlaying)
            {
                // Play the sound with looping enabled.
                AudioSource audioSource = GetComponent<AudioSource>();
                if (audioSource != null && soundToPlay != null)
                {
                    audioSource.clip = soundToPlay;
                    audioSource.loop = true; // Enable looping.
                    audioSource.Play();
                    isAudioPlaying = true;
                }

                // Destroy the correct record.
                Destroy(other.gameObject);
            }
        }
    }
}
