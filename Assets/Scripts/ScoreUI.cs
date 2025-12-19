using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI aiScore,playerScore;


    public void UpdateAiScore()
    {
        int currentScore = int.Parse(aiScore.text);
        currentScore++;
        aiScore.text = currentScore.ToString();
    }

    public void UpdatePlayerScore()
    {
        int currentScore = int.Parse(playerScore.text);
        currentScore++;
        playerScore.text = currentScore.ToString();
    }
}
