using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpController : MonoBehaviour
{
    [Header("Pickup Settings")]
    [SerializeField] Transform holdArea;
    public GameObject HeldObject { get; private set; } // Expose the currently held object
    private Rigidbody heldObjRB;

    [Header("Physics Parameters")]
    [SerializeField] private float pickupRange = 5.0f;
    [SerializeField] private float pickupForce = 150.0f;

    [SerializeField] GameObject ticketPrefab; // Assign the ticket prefab in the Inspector.
    [SerializeField] string correctTag = "CorrectObj"; // Set the correct tag.

    [SerializeField] Transform ticketSpawnPoint; // Reference to the spawn point empty GameObject.

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (HeldObject == null)
            {
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, pickupRange))
                {
                    PickupObject(hit.transform.gameObject);
                }
            }
            else
            {
                DropObject();
            }
        }
        if (HeldObject != null)
        {
            MoveObject();
        }
    }

    void MoveObject()
    {
        if (Vector3.Distance(HeldObject.transform.position, holdArea.position) > 0.1f)
        {
            Vector3 moveDirection = (holdArea.position - HeldObject.transform.position);
            heldObjRB.AddForce(moveDirection * pickupForce);
        }
    }

    void PickupObject(GameObject pickObj)
    {
        if (pickObj.GetComponent<Rigidbody>())
        {
            heldObjRB = pickObj.GetComponent<Rigidbody>();
            heldObjRB.useGravity = false;
            heldObjRB.drag = 10;
            heldObjRB.constraints = RigidbodyConstraints.FreezeRotation;

            heldObjRB.transform.parent = holdArea;
            HeldObject = pickObj; // Set the currently held object
        }
    }

    void DropObject()
    {
        if (HeldObject.CompareTag(correctTag))
        {
            // The correct object has been dropped on the target.
            // Instantiate the ticket object at the spawn point.
            Instantiate(ticketPrefab, ticketSpawnPoint.position, Quaternion.identity);
        }

        heldObjRB.useGravity = true;
        heldObjRB.drag = 1;
        heldObjRB.constraints = RigidbodyConstraints.None;

        heldObjRB.transform.parent = null;
        HeldObject = null; // Reset the currently held object
    }
}
