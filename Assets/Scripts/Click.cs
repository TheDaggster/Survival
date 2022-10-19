using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public AudioSource source;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ClickMouse()
    {
        source.Play();
    }
}
