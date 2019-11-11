using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum GameState
{
    Started,
    Finished
}

public class GameManager : MonoBehaviour
{ 
    private GameState gameStatus;

    public GameObject GameOverPanel;

    void Start()
    {
        gameStatus = GameState.Started;
    }
    public GameState GetGameState()
    {
        return gameStatus;
    }

    public void FinishGame()
    {
        GameOverPanel.SetActive(true);
        gameStatus = GameState.Finished;
        Time.timeScale = 0;
    }

    public bool IsGameFinished()
    {
        return (gameStatus == GameState.Finished);
    }

    public void RestartGame()
    {
        GameOverPanel.SetActive(false);
        gameStatus = GameState.Started;
        Time.timeScale = 1;
    }
}
