using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameUI gameUI;
    public int scorePlayer1, scorePlayer2; 
    public Action onReset;
    public int maxScore = 4;

    private void Awake()
    {
        if (instance)
        { 
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            gameUI.OnStartGame =+ OnStartGame;
        }
    }

    public void OnScoreZoneReached(int id)
    {

        if (id == 1)
            scorePlayer1++;
    
        if (id == 2)
            scorePlayer2++;

        gameUI.UpdatedScores(scorePlayer1, scorePlayer2);
        gameUI.HighlightScore(id);
        CheckWin();
    }

    public void CheckWin()
    {
        int winnerId = scorePlayer1 == maxScore ? 1 : scorePlayer2 == maxScore ? 2 : 0;

        if (winnerId != 0)
        {
            gameUI.OnGameEnds(winnerId);
        }
        else
        {
            onReset?.Invoke();
        }
    }

    private void OnStartGame()
    {
        scorePlayer1 = 0;
        scorePlayer2 = 0;
        gameUI.UpdateScores(scorePlayer1, scorePlayer2);
    }
}
