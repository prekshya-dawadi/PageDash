using UnityEngine;
using TMPro;
public class rotationScore : MonoBehaviour
{
    int score = 0;
    [SerializeField] TextMeshProUGUI  ScoreBoard;

    public void IncrementScore()
    {
        score++;
        ScoreBoard.text = "Score: " + score;

    }
}
