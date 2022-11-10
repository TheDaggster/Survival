using UnityEngine;
public class Enemy : MonoBehaviour
{
    public int health = 100;
    // This is used to signal the number of health the enemy has which is set to 100; 
    public GameObject deathEffect;
    // Currently has no use as of now but is used later in my game to create a animation so when the enemy is 
    // Destroyed from damage taken being <= 0 a small animation would play to help signify to the player the enemy has
    // Died. 
    public void TakeDamage (int damage)
    // the "TakeDamage" script is used between "Enemy" script and the "Bullet" "script 
    // this script has a (int damage) this is referred in the "Bullet" script in the public int damage which holds the value
    // of 20. This can be changed at anytime but is used here to save constantly reifying the same value over and over. 
    {
        health -= damage;
        // Health is subtracted from the damage from the bullet so to clarify 
        // Health = 100 damage = 20 100 - 20 formalised as a script. 
        if (health <= 0)
            // Then Made a IF statement so if health (100) equals less than 0 so -1 for example I want it to play 
        // another void which i labelled as "void Dead"
        {
            Dead();
            // I then send a signal to have "Void Dead be used if Health is less than 0
        }
    }


    void Dead()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        // I then Use a instantiate to move the object from the Enemy object into a "deathEffect" which changes the value
        // from a physical object into a animation when played.
        Destroy(gameObject);
        // Then when the animation has been played the object is then destroyed to stop the "Enemy"
    }
}