using UnityEngine;
using UnityEngine.SceneManagement;

public class Door2 : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
        // On Collision with Entity (This being a Invisible Door viewable in Scene)
    {
        GameObject collisionGameObject = collision.gameObject;
        // If "GameObject" has a collision from another Collision 

        if (collisionGameObject.name == "Player")
            // If collision Name of object is labelled as "Player" 
        {
            SceneManager.LoadScene("TestHouseFlip");
            // Load into new scene "TestHouseFlip" on contact with Player sprite.
            
            
            
            // For Clarification i made this script to combat duplication so even though i would have to constantly remake
            // this script for other doors and so forth it would cause the bug to unable to exist. 

        }
    }
}
