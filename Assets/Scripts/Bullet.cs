using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 20f;
    // This is used to signal how fast a bullet speed will be shot at 
    public int damage = 20;
    // The int number (20) determines how much damage is dealt when inflicted on a Object
    public Rigidbody2D rb;
    // This is used to indicate the body of my bullet object it uses the speed of force and its transform to indicate
    // positioning. since my code is built on .right it was best keeping it this way. 

    void Start()
    {
        rb.velocity = transform.right * speed;
        // Using the Public Rigidbody above and the basic transform Times by the float speed of 20f indicated above.
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    // I then created a OnTrigger Event so if the bullet hits a 2D Collider such as a box Collider seen on the Enemy
    // It will then process this code into hitting the target and create the following code. 
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        // I then use Enemy script so it can find path in my other script to find its health and takeDamage modules
        if (enemy != null)
            // if the enemy health hits 0 or Null which is put here. 
        {
            enemy.TakeDamage(damage);
            // then the TakeDamage script from the enemy script is used where its using the int described above which
            // is (20) damage this can be altered to 30,40,50+ but as soon as the total damage hits over 100 
            // the enemy code then plays this OnTrigger Script shown in the "Enemy" script for "Void Death"
        }
        Destroy(gameObject);
        // This is created after interaction with OnTrigger to Stop the bullet going any more further after interaction
        // with the enemy. Destroy gameObject refers to the bullet itself destroying the bullet on contact with the collider 
        
    }
}
