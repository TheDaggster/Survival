using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
   public float health = 100;
   public float speed = 600f;
   public Weapon weapon;
   private Rigidbody2D _body;


   private void Awake()
   {
      _body = GetComponent<Rigidbody2D>();
      if (SceneManager.GetActiveScene().name == "Main Menu") Destroy(gameObject);
   }

   public void Update()
   {
      if (Input.GetKey(KeyCode.A))

      {

         transform.localRotation = Quaternion.Euler(0, 180, 0);
         transform.Translate(Vector2.right * (speed * Time.deltaTime));

      }

      if (Input.GetKey(KeyCode.D))

      {

         transform.localRotation = Quaternion.Euler(0, 0, 0);
         transform.Translate(Vector2.right * (speed * Time.deltaTime));
      }

      if (Input.GetButtonDown("Fire1"))
         // If the user decides to press "Fire1" (Left mouse button) they will play another void called "Fire"
      {
         weapon.Fire(); // "Fire" is then triggered upon pressing "Fire1"
      }

      if (Input.GetKeyDown(KeyCode.R))
      {
         weapon.Reload();
      }
   }

   void Tdp (int damage)
   {
      health -= damage;
   }
  
   private void OnCollisionEnter(Collision collision)
   {
      if (collision.collider.gameObject.CompareTag("Enemy"))
      {
         Tdp (40);
      }
   }
}