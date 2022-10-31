using UnityEngine;
using UnityEngine.SceneManagement;

public class Door1 : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collisionGameObject = collision.gameObject;

        if(collisionGameObject.name == "Player") 
        {
            SceneManager.LoadScene("HouseTest2");
            
        }
    }
    
}
