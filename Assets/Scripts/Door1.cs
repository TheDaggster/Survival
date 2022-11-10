using UnityEngine;
using UnityEngine.SceneManagement;

public class Door1 : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    // On Collision with Entity (This being a Invisible Door viewable in Scene)
    {
        GameObject collisionGameObject = collision.gameObject;
        // If "GameObject" has a collision from another Collision 

        if(collisionGameObject.name == "Player") 
            // If collision Name of object is labelled as "Player" 
        {
            SceneManager.LoadScene("HouseTest2");
            // Load into new scene "HouseTest2" on contact with Player sprite.
            
        }
    }
    
}
