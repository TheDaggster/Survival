using UnityEngine;
using UnityEngine.SceneManagement;

public class BGM : MonoBehaviour
{
    private static BGM _bgm;

    void Awake()
    {
        if (_bgm == null)
        {
            _bgm = this;
        
        }

        else
        // Added a else command to Destroy the sound source playing when starting the game. 
        {
          if(SceneManager.GetActiveScene().name == "HouseTest")
              // If the scene = "HouseTest" which is the first scene when you press the start button
              Destroy(_bgm);
             // Destroy Object "_bgm" to stop audio source playing when starting game.  
        }
    }
}