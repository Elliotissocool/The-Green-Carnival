using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOpener : MonoBehaviour
{
    public string ticketTag = "Ticket"; // Tag for the ticket object.
    public Transform gateTransform; // Reference to the gate's Transform.
    public float openAngle = 90.0f; // Angle by which the gate should open.

    private bool isOpen = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(ticketTag) && !isOpen)
        {
            // Ticket entered the gate's trigger area.
            OpenGate();
        }
    }

    private void OpenGate()
    {
        // Rotate the gate to open it.
        gateTransform.Rotate(Vector3.up, openAngle);
        isOpen = true;

        // You can also play a gate opening sound or trigger any other effects here.
    }
}
