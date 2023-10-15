using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextController : MonoBehaviour
{
    public GameObject textObject; // Reference to the 3D text GameObject.

    private void Start()
    {
        // Initially hide the 3D text.
        textObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Assuming the player has a "Player" tag.
        {
            // Show the 3D text when the player enters the trigger area.
            textObject.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Hide the text when the player exits the collider
            textObject.SetActive(false);
        }
    }
}
