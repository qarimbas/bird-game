using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public event Action<GameState> OnGameStateChanged;

    [Header("References")]

    [SerializeField] private EggCounterUI _eggCounterUI;
    [SerializeField] private WinLoseUI _winLoseUI;


    [Header("Egg Collection Settings")]

    [SerializeField] private int _maxEggCount = 5;

    private GameState _currentGameState;

    private int _currentEggCount;

    private void Awake()
    {
        Instance = this;
    }

    private void OnEnable()
    {
        ChangeGameState(GameState.Play);
    }

    public void ChangeGameState(GameState gameState)
    {
        OnGameStateChanged?.Invoke(gameState);
        _currentGameState = gameState;
        Debug.Log($"Game state changed to: {_currentGameState}");
    }

    public void OnEggCollected()
    {
        _currentEggCount++;
        _eggCounterUI.SetEggCounterText(_currentEggCount, _maxEggCount);

        if (_currentEggCount == _maxEggCount)
        {
            ChangeGameState(GameState.GameOver);
            _eggCounterUI.SetEggCompleted();
            _winLoseUI.OnGameWin();
        }
    }

    public GameState GetCurrentGameState()
    {
        return _currentGameState;
    }
}
