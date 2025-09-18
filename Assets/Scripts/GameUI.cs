using UnityEngine;

public class GameUI : MonoBehaviour
{
    public ScoreText scoreTextPlayer1, scoreTextPlayer2; 
    public GameObject menuObject;
    public TextMeshProUGUI winText;

    public System.Action OnStartGame;

    public void UpdatedScores(int scorePlayer1, int scorePlayer2)
    {
        scoreTextPlayer1.SetScore(scorePlayer1);
        scoreTextPlayer2.SetScore(scorePlayer2);
    }

    public void HighlightScore(int id)
    {
        if (id == 1)
            scoreTextPlayer1.Highlight();
        else
            scoreTextPlayer2.Highlight();
    }

    public void OnStartGameButtonClicked()
    {
        menuObject.SetActive(false);
        OnStartGame?.Invoke();
    }

    public void OnGameEnds(int winnerId)
    {
        menuObject.SetActive(true);
        winText.text = $"Player {winnerId} wins!";
    }
} 
