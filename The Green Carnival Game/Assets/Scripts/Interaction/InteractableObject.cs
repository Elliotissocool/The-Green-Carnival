using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    private bool isInteractable = false;

    private void OnMouseDown()
    {
        if (isInteractable)
        {
            // Handle the interaction here (e.g., play a sound, trigger an event).
            // You can also destroy the object or perform other actions.
            Debug.Log("Object interacted with!");
        }
    }

    public void SetInteractable(bool value)
    {
        isInteractable = value;
    }
}
