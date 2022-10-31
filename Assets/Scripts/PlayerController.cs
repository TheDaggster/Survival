using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
   public float health = 100f;
   public float speed = 500f;
   private Vector2 respawn;
   private Rigidbody2D body;
   private static GameObject Instance;

   void Awake()
   {
      body = GetComponent<Rigidbody2D>();
   }


   private void OnLevelReturn(int level)
   {
      ReturnPos();
   }

   void FindStartPos()
   {
      transform.position = GameObject.FindWithTag("StartPos").transform.position;
   }

   void ReturnPos()
   {
      transform.position = GameObject.FindWithTag("ReturnPos").transform.position;
   }

   private void Update()
   {
      body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);
      if (SceneManager.GetActiveScene().name == "Main Menu") Destroy(gameObject);
   }

}