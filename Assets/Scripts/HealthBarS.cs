using UnityEngine;
using UnityEngine.UI;

public class HealthBarS : MonoBehaviour
{
  private Image _healthBar;
  public float currentHealth;
  private float MaxHealth = 100f;
  PlayerController _player;

  private void Start()
  {
    //Find
    _healthBar = GetComponent<Image>();
    _player = FindObjectOfType<PlayerController>();
  }

  private void Update()
  {
    currentHealth = _player.health;
    _healthBar.fillAmount = currentHealth / MaxHealth;
  }
}

