using UnityEngine;
using System.Collections;

public class SquashCharacter : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player triggered with Page!");
            StartCoroutine(TimeDelay());
        }
    }

    IEnumerator TimeDelay()
    {
        yield return new WaitForSeconds(0.01f);

        // Destroy the player sphere
        Destroy(GameObject.FindWithTag("Player"));
        Debug.Log("Player destroyed");
    }
}
