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
   
   private void Update()
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

   }
}