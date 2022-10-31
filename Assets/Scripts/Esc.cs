
using UnityEngine;
using UnityEngine.SceneManagement;

public class Esc : MonoBehaviour
{
   public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("MainMenu");
        else
        {
            if (SceneManager.GetActiveScene().name == "Main Menu")
                Destroy(GameObject.FindWithTag("Player"));
        }
        
        // Debug.Log("Returning to Menu"); - Reason is spamming the console consistently because of "Update"
    }
   
}

