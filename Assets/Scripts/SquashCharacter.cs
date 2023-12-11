// using UnityEngine;
// using System.Collections;

// public class SquashCharacter : MonoBehaviour
// {
//     // Reference to the page material
//     public Material pageMaterial;

//     private void OnTriggerEnter(Collider other)
//     {
//         Debug.Log("Collider triggered.");
//         // Check if the collided object's material is the page material
//         if (other.gameObject.GetComponent<Renderer>().material == pageMaterial)
//         {
//             // Ensure it's not a hole collider
//             Debug.Log("Material detected.");
            
//             if (!other.CompareTag("HoleCollider"))
//             {
//                 Debug.Log("Player collided with page!");
//                 StartCoroutine(TimeDelay());
//             }
//         }
//         // else if (other.CompareTag("Character"))
//         // {
//         //     // Handle collision with other characters
//         //     Debug.Log("collided with characters.");
//         // }
//     }

//     IEnumerator TimeDelay()
//     {
//         yield return new WaitForSeconds(0.5f);

//         // Destroy the player sphere
//         Destroy(GameObject.FindWithTag("Character"));
//         Debug.Log("player ded");
//     }
// }


using UnityEngine;
using System.Collections;

public class SquashCharacter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("HoleCollider") && other.CompareTag("Page"))
        {
            Debug.Log("Player triggered with Page!");
            StartCoroutine(TimeDelay());
        }

        if(other.CompareTag("Character")){
            Debug.Log("Collided with another character.");
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