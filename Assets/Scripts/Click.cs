using UnityEngine;

public class Click : MonoBehaviour
{
    public AudioSource source;
    // creates a AudioSource clip which allows the user to add a AudioSource here:
    
    public void ClickMouse()
    // I then made a click script which basically makes a small click noise on every button i want there to be a click on.
    {
        source.Play();
        // This will then play the sound clip once on click of the mouse signaled to the button. 
    }
}
