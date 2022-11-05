using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static GameState State;
    public static event Action<GameState> OnGameStateChanged;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    private void Start()
    {
        UpdateGameState(GameState.SelectVelocity);
    }

    public void UpdateGameState(GameState newState)
    {
        State = newState;
        switch (newState)
        {
            case GameState.SelectVelocity:
                break;
            case GameState.Simulation:
                break;
            case GameState.Victory:
                break;
            case GameState.Lose:
                break;
        }
        OnGameStateChanged?.Invoke(newState);
    }
}

public enum GameState
{
    SelectVelocity,
    Simulation,
    Victory,
    Lose
}
