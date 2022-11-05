using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _velocitySelectPanel,_simulationPanel, _victoryPanel, _losePanel;

    private void Awake()
    {
        GameManager.OnGameStateChanged += GameManagerOnGameStateChanged;
    }

    private void OnDestroy()
    {
        GameManager.OnGameStateChanged -= GameManagerOnGameStateChanged;
    }

    private void GameManagerOnGameStateChanged(GameState state)
    {
        _velocitySelectPanel.SetActive(state == GameState.SelectVelocity);
        _simulationPanel.SetActive(state == GameState.Simulation);
        _victoryPanel.SetActive(state == GameState.Victory);
        _losePanel.SetActive(state == GameState.Lose);
    }
}
