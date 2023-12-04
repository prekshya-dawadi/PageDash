using UnityEngine;

public class SquashCharacter : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("Page"))
        {
            Debug.Log("Player collided with Page!");
            Destroy(gameObject);
        }
    }

}
