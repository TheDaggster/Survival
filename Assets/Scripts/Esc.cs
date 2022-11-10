
using UnityEngine;
using UnityEngine.SceneManagement;

public class Esc : MonoBehaviour
{
   public void Update()
   // The idea of this Script is a Temporal Menu Escape to stop Soft-locking / Forced to Quit game 
   // So to combat this I made a script where Pressing "ESC" or "Escape" button would revert back to the MainMenu
   // This is currently in use temporally in till a full menu is created.
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            // When pressing the Key "Escape" the following lines of Code is Played. 
            SceneManager.LoadScene("MainMenu");
              // this reverts back and loads the "MainMenu" scene 
        else // I also added a else to this script since I had issues where the player would often teleport to the 
            // main menu as well causing multiplication in the game and also often player being shown in the Main Menu
        {
            if (SceneManager.GetActiveScene().name == "Main Menu")
                // So I decided to attach this small script which indicates if the scene active is currently listed as
                // "Main Menu" I then want the script to find if there is a tag with the name of "Player"
                Destroy(GameObject.FindWithTag("Player"));
                // If there is a tag named player (Since Player isn't in the main menu to start with this indication -
                // Should raise a alarm to the script) Then proceeds to "Destroy" any "GameObject" with the tag shown in "".
        }
        
        // Debug.Log("Returning to Menu"); - Reason is spamming the console consistently because of "Update"
        // to Clarify on the debug above the update constantly checking for it is causing the debug.log to constantly write this.
    }
   
}

