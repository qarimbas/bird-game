using UnityEngine;

public class HealthManager : MonoBehaviour
{
    [SerializeField] private int _maxHealth = 3;

    private int _currentHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;
    }


    public void Damage(int damage)
    {
        if(_currentHealth > 0)
        {
            _currentHealth -= damage;
            //TODO : Play damage animation, sound, etc.
            if (_currentHealth <= 0)
            {
                //PLAYER DED
                Debug.Log("Player is dead!");
            }
        }
    }

    public void Heal(int healAmount)
    {
        if(_currentHealth < _maxHealth)
        {
            _currentHealth = Mathf.Min(_currentHealth + healAmount, _maxHealth);
        }
    }
}
