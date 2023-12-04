// Attach this script to "Player" sphere
using UnityEngine;

public class SquashCharacter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Page") || other.CompareTag("Character"))
        {
            Debug.Log("Player triggered with Page!");
            // Perform any actions or effects as needed
            Destroy(gameObject); // Destroy the player object in this example
        }
    }
}
