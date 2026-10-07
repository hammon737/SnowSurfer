using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;

    int score = 0;
    
    public void AddScore(int additionalScore)
    {
        score += additionalScore;
        scoreText.text = "Score: " + score;
    }


}
