using UnityEngine;


public enum State
{
    Idle,
    Patrol,
    Attack
}

public class EnemyController : MonoBehaviour
{
    private State enemyState = State.Patrol;
    public Transform[] positions;
    private int currentLocation = 0;
    public float speed = 1;
    public float enemyRange = 7f;
    private Vector2 newLoc;
    public LayerMask PlayerMask;
    private Rigidbody2D body;
    private Vector2 movementDir = Vector2.zero;
    private Vector2 lookAt = Vector2.zero;
    public Transform missile;
    public float shootRange = 6f;
    public int health = 100; 
    // control enemy rate of fire
    public int rateOfFire = 30;
    private int lastFired = 0;
    
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (enemyState)
        {
            case State.Idle:
                break;
            case State.Patrol:
                Patrol();
                break;
            case State.Attack:
                Attack();
                break;
        }
    }

    private void Attack()
    {
        Debug.DrawRay(transform.position, lookAt * enemyRange, Color.red);
        Shoot();
        enemyState = State.Patrol;
    }

    private void Shoot()
    {
        lastFired++;
        if (lastFired < rateOfFire)
        {
            return;
        }
        lastFired = 0;
        var missileInstance = Instantiate(missile, transform.position, Quaternion.identity);
        Rigidbody2D missileRB = missileInstance.GetComponent<Rigidbody2D>();
        Vector2 shootDir = lookAt + Vector2.up;
        missileRB.AddForce(shootDir * shootRange, ForceMode2D.Impulse);
        Destroy(missileInstance.gameObject, 2f);
    }

    private void Patrol()
    {
        Vector2 currentLoc = transform.position;
        Vector2 nextPatrolPoint = positions[currentLocation].position;
        movementDir = nextPatrolPoint - currentLoc;
        body.MovePosition(currentLoc + movementDir.normalized * (Time.deltaTime * speed));
        float distance = Vector2.Distance(currentLoc, nextPatrolPoint);
        
        if (distance < 0.5f)
        {
            currentLocation++;
            if (currentLocation == positions.Length)
            {
                currentLocation = 0;
            }
            Debug.Log($"distance {distance} {currentLocation}");
        }
        if (PlayerInSight())
        {
            enemyState = State.Attack;
        }
    }

    bool PlayerInSight()
    {
        Vector2 pos = transform.position;
        lookAt = new Vector2(movementDir.x, 0).normalized;
        // Does the ray intersect any objects excluding the player layer
        if (Physics2D.Raycast(pos, lookAt, enemyRange, PlayerMask ))
        {
            Debug.DrawRay(pos, lookAt * enemyRange, Color.red);
           // Debug.Log("Did Hit");
            return true;
        }
        else
        {
            Debug.DrawRay(transform.position, lookAt * enemyRange, Color.white);
            //Debug.Log("Did not Hit");
        }
        return false;
    }
    public void TakeDamage(int d)
    {
        health -= d;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}