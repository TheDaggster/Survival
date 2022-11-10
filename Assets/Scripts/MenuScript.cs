using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour

{

    public void Startup()
    {
        SceneManager.LoadScene("HouseTest"); // Scene Added
        Debug.Log("Loading game!"); // Debug message to notify the scene has been loaded. 
        
        // This makes it when a button is given the command Startup() it will trigger a command to load into the 
        // next scene change in game and the debug log is to check the game is loading correctly into next scene.
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Quit Game!"); // Debug message to notify the Application has quit. 
        
        // the button will then make the game quit and I then wanted a message to confirm this 
        // so i made sure to add a debug log message to announce in console "Quit Game!".
    }
    
    // Option Script 
    // -----------------------------------------------------------------------------------------------------------

    public void Fullscreen()
    {
        Screen.fullScreen = !Screen.fullScreen; // This toggles the fullscreen mode 
        Debug.Log("FullScreen mode On/Off"); // Since it can only be toggled I referred to it being "On/Off"
        
        // Using code from "https://docs.unity3d.com/ScriptReference/Screen-fullScreen.html"
        // Pressing the button causes the screen to go in full screen mode on/off can be toggled. 
    }
    
}
