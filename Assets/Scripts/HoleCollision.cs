using UnityEngine;

public class HoleCollision : MonoBehaviour
{
    private Collider holeCollider;

    private void Start()
    {
        holeCollider = GetComponent<Collider>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Page") || collision.collider.CompareTag("Character"))
        {
            Debug.Log("Player triggered with hole!");
            holeCollider.enabled = false;
        }
    }
}
