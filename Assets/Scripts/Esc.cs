using UnityEngine;
using UnityEngine.SceneManagement;

public class Esc : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("MainMenu");
        // Debug.Log("Returning to Menu"); - Reason is spamming the console consistently because of "Update"
    }

}

