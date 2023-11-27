using UnityEngine;

public class CubeAnimation : MonoBehaviour
{
    public float rotationSpeed = 5f;
    public float amplitude = 1.5f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Rotate the cube around its center
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);

        // Move the cube in a circular motion
        float x = startPosition.x + Mathf.Sin(Time.time) * amplitude;
        float y = startPosition.y;
        float z = startPosition.z + Mathf.Cos(Time.time) * amplitude;

        transform.position = new Vector3(x, y, z);
    }
}
