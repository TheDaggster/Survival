using UnityEngine;
using UnityEngine.SceneManagement;

public class BGM : MonoBehaviour
{
    private static BGM bgm;

    void Awake()
    {
        if (bgm == null)
        {
            bgm = this;
        
        }

        else
        {
          if(SceneManager.GetActiveScene().name == "HouseTest")
            Destroy(bgm);
        }
    }
}