using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour

{

    public void Startup()
    {
        SceneManager.LoadScene("HouseTest"); // Scene Added
        Debug.Log("Loading game!");
        // This makes it when a button is given the command Start() it will trigger a command to load into the 
        // next scene change in game and the debug log is to check the game is loading correctly into next scene.
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Quit Game!");
        // the button will then make the game quit and I then wanted a message to confirm this 
        // so i made sure to add a debug log message to announce in console "Quit Game!"
    }
    
    // Option Script 
    // -----------------------------------------------------------------------------------------------------------

    public void Fullscreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
        Debug.Log("FullScreen mode On/Off");
        // Using the code from the Unity API ref~
        // Pressing the button causes the screen to go in full screen mode on/off
    }
    
}
