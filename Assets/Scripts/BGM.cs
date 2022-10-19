using System;
using System.Collections;
using System.Collections.Generic;
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
            DontDestroyOnLoad(bgm);
        }

        else
        {
            SceneManager.LoadScene("Cutscene1");
            Destroy(gameObject);
        }
    }
}