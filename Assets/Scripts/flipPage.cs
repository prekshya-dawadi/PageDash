using UnityEngine;

public class FlipPage : MonoBehaviour
{
    private bool flip = false;
    private float flipDuration = 3.0f;
    private float startTime;
    private float decayFactor = 0.98f; 

    void Start()
    {
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
        int currentScore = FindObjectOfType<rotationScore>().IncrementScore();
        flipDuration = CalculateNewFlipDuration(currentScore);
        Debug.Log("Current Speed: " + flipDuration);

        startTime = Time.time;
    }

    // new flipDuration based on the current score
    private float CalculateNewFlipDuration(int score)
    {
        return Mathf.Max(0.3f, flipDuration * Mathf.Pow(decayFactor, score)); // flipDuration doesn't go below a minimum value
    }
}
