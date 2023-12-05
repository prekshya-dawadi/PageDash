using UnityEngine;
using System.Collections;

public class SquashCharacter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Page") || other.CompareTag("Character"))
        {
            Debug.Log("Player triggered with Page!");
            StartCoroutine(TimeDelay());
        }
    }

    IEnumerator TimeDelay()
    {
        yield return new WaitForSeconds(0.5f);

        // Destroy the player sphere
        Destroy(GameObject.FindWithTag("Character"));
        Debug.Log("player ded");
    }
}
