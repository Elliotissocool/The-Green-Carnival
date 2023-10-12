using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    [SerializeField] private string soundTag = "SoundTriggerObject"; // The tag of objects that trigger sounds.
    [SerializeField] private AudioClip dropSound; // The sound to play when the object is dropped in the trigger area.

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(soundTag))
        {
            // Log a debug message to the console.
            Debug.Log("Object triggered sound: " + other.name);

            // Play the sound (if you have sound configured).
            if (dropSound != null)
            {
                AudioSource audioSource = GetComponent<AudioSource>();
                if (audioSource != null)
                {
                    audioSource.clip = dropSound;
                    audioSource.Play();
                }
            }
        }
    }
}
