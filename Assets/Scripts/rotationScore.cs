using UnityEngine;
using TMPro;
public class rotationScore : MonoBehaviour
{
    int score = 0;
    [SerializeField] TextMeshProUGUI  ScoreBoard;

    public int IncrementScore()
    {
        
        ScoreBoard.text = "Score: " + score;
        score++;
        return score;
    }

}
