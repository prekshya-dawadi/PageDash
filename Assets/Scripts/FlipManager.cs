using UnityEngine;

public class FlipManager : MonoBehaviour
{
    public FlipPage flip;
    public GameObject firstObject;
    public GameObject secondObject;

    private bool isFirstObjectFlipping = false;

    void Start()
    {
        StartFlipping(firstObject);
    }

    void StartFlipping(GameObject targetObject)
    {
        flip.StartFlip(targetObject);
        isFirstObjectFlipping = true;
    }

    public void OnFlipFinished()
    {
        if (isFirstObjectFlipping)
        {
            isFirstObjectFlipping = false;
            StartFlipping(secondObject);
        }
    }
}
