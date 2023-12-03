using UnityEngine;

public class FlipPage : MonoBehaviour
{
    private bool flip = false;
    private float flipDuration = 1.5f;  // Adjust the duration as needed
    private float startTime;
    private Vector3 originalPosition;

    void start(){
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

    public void StartFlip()
    {
        Rotate();
        flip = true;
    }

    private void Rotate()
    {
        startTime = Time.time;
    }
}