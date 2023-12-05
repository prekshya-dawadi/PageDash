using UnityEngine;

public class CustomMeshColliderSetter : MonoBehaviour
{
    void Start()
    {
        // Get the MeshCollider component
        MeshCollider meshCollider = GetComponent<MeshCollider>();

        // Assuming your prefab has a MeshFilter component
        MeshFilter meshFilter = GetComponentInChildren<MeshFilter>();

        // if (meshCollider != null && meshFilter != null)
        // {
            // Assign the mesh from the MeshFilter to the MeshCollider
        meshCollider.sharedMesh = meshFilter.sharedMesh;
        // }
    }
}
