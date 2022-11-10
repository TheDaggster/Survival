using UnityEngine;
using UnityEngine.UI;

public class HealthBarS : MonoBehaviour
{
  private Image _healthBar;
  // Add a Image to indicate the Health bar
  public float currentHealth;
  // add a float that helps acknowledge current health 
  private float MaxHealth = 100f;
  // add a float that indicates what the total amount of health is (100) 
  PlayerController _player;
  // I then attach the PlayerController Script and indicate im referring to the player. 

  private void Start()
  {
    //Finds the Health-bar image Labelled below. 
    _healthBar = GetComponent<Image>();
    _player = FindObjectOfType<PlayerController>();
    // This is then finding the player object that is connected to the "PlayerController" script
  }

  private void Update()
  // Used to constantly update health in case player was to take damage it then updates to reflect this on the script
  // and also the health bar shown in the top left corner. 
  {
    currentHealth = _player.health;
    // this is used to indicate the current health = players health. If the player health goes down so does the current health
    // which then indicates for the health bar to move down so the person playing can identify they taking damage from a attack. 
    _healthBar.fillAmount = currentHealth / MaxHealth;
    // this is used to indicate the fill amount since our health is a slider UI initially it requires to know our
    // MaxHealth (100) and our currentHealth (this can be determined on if the player is damaged)
  }
}

