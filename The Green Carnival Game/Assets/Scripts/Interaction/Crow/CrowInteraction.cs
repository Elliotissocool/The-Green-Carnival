using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowInteraction : MonoBehaviour
{
    [SerializeField] GameObject ticketPrefab; // The prefab of the ticket model
    [SerializeField] string correctItemTag = "TicketObject"; // Tag of the correct item

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PickUpController playerController = other.GetComponent<PickUpController>();
            if (playerController != null && playerController.HeldObject != null &&
                playerController.HeldObject.CompareTag(correctItemTag))
            {
                // The player has dropped the correct item, spawn the ticket
                Instantiate(ticketPrefab, transform.position, Quaternion.identity);
            }
        }
    }
}
