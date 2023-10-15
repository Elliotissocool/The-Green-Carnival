using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowInteraction : MonoBehaviour
{
    [SerializeField] GameObject ticketPrefab; // The prefab of the ticket model.
    [SerializeField] string correctObjectName = "TicketObject"; // Name of the correct object.

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PickUpController playerController = other.GetComponent<PickUpController>();
            if (playerController != null && playerController.HeldObject != null &&
                playerController.HeldObject.name == correctObjectName)
            {
                Debug.Log("Player entered the trigger zone.");
                // The player has dropped the correct item, spawn the ticket.
                Instantiate(ticketPrefab, transform.position, Quaternion.identity);
            }
        }
    }
}
