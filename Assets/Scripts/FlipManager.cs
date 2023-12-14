using UnityEngine;
using UnityEngine.UI;

public class FlipManager : MonoBehaviour
{
    public FlipPage flip;
    public GameObject firstPage;
    public GameObject secondPage;
    public GameObject thirdPage;
    public GameObject fourthPage;
    public GameObject fifthPage;
    GameObject[] pageCollection = new GameObject[5];
    private bool isFirstObjectFlipping = false;
    public rotationScore rotationScore;


    void Start()
    {
        pageCollection[0] = firstPage;
        pageCollection[1] = secondPage;
        pageCollection[2] = thirdPage;
        pageCollection[3] = fourthPage;
        pageCollection[4] = fifthPage;

        StartFlip(pageCollection[Random.Range(0, pageCollection.Length)]);
    }

    void StartFlip(GameObject targetObject)
    {
        FlipPage flipPageComponent = targetObject.GetComponent<FlipPage>();
        if (flipPageComponent != null)
        {
            flipPageComponent.StartFlip();
            int updatedScore = rotationScore.IncrementScore();


        }
        else
        {
            Debug.LogError("No FlipPage component found on the target object: " + targetObject.name);
        }

        isFirstObjectFlipping = true;
    }

    public void OnFlipFinished()
    {
        if (isFirstObjectFlipping)
        {
            isFirstObjectFlipping = false;
            StartFlip(pageCollection[Random.Range(0, pageCollection.Length)]);
        }
    }


}