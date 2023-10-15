using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowInteraction : MonoBehaviour
{
    [SerializeField] GameObject ticketPrefab; // The prefab of the ticket model.
    [SerializeField] string correctObjectTag = "CorrectObj"; // Tag of the correct object.

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player dropped the correct item at the crow's feet based on its tag.
        if (other.CompareTag(correctObjectTag))
        {
            Debug.Log("Correct object dropped at the crow's feet.");
            // The correct object has been dropped, spawn the ticket.
            Instantiate(ticketPrefab, transform.position, Quaternion.identity);

            // Optionally, you can destroy the correct object after spawning the ticket.
            Destroy(other.gameObject);
        }
    }
}
