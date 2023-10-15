using UnityEngine;

public class TextController : MonoBehaviour
{
    // Reference to your text object
    public GameObject textObject;

    private void Start()
    {
        // Initially, hide the text
        textObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Show the text when the player enters the collider
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
