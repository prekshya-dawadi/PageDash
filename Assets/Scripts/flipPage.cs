using UnityEngine;

public class FlipPage : MonoBehaviour
{
    private Vector3 rotationVector;
    private bool flip = false;
    private float flipDuration = 1.5f;  // Adjust the duration as needed
    private float startTime;

    void Start()
    {
        Rotate();
    }

    void Update()
    {
        if (flip)
        {
            float t = (Time.time - startTime) / flipDuration;
            transform.rotation = Quaternion.Euler(Mathf.Lerp(0, -90, t), 0, 0);

            if (t >= 1.0f)
            {
                flip = false;
                FindObjectOfType<FlipManager>().OnFlipFinished();
            }
        }
    }

    public void StartFlip(GameObject targetObject)
    {
        Rotate();
        flip = true;
    }

    void Rotate()
    {
        startTime = Time.time;
    }
}
