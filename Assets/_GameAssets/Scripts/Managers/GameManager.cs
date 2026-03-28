using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [Header("References")]

    [SerializeField] private EggCounterUI _eggCounterUI;


    [Header("Egg Collection Settings")]

    [SerializeField] private int _maxEggCount = 5;

    private int _currentEggCount;

    private void Awake()
    {
        Instance = this;
    }

    public void OnEggCollected()
    {
        _currentEggCount++;
        _eggCounterUI.SetEggCounterText(_currentEggCount, _maxEggCount);

        if (_currentEggCount == _maxEggCount)
        {
            // Implement win 
            Debug.Log("All eggs collected! You win!");
            _eggCounterUI.SetEggCompleted();
        }
        Debug.Log($"Egg collected! Current count: {_currentEggCount}/{_maxEggCount}");
    }
}
