using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
   public float health = 100f;
   public float speed = 600f;
   public Weapon weapon;
   private Vector2 respawn;
   private Rigidbody2D body;


   void Awake()
   {
      body = GetComponent<Rigidbody2D>();
      if (SceneManager.GetActiveScene().name == "Main Menu") Destroy(gameObject);
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
      if (Input.GetKeyDown(KeyCode.A))

      {

         transform.localRotation = Quaternion.Euler(0, 180, 0);
         transform.Translate(Vector2.right * (speed * Time.deltaTime)); 

      }

      if (Input.GetKeyDown(KeyCode.D))

      {

         transform.localRotation = Quaternion.Euler(0, 0, 0);
         transform.Translate(Vector2.right * (speed * Time.deltaTime));
      }

   }
}