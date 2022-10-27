using UnityEngine;

public class Click : MonoBehaviour
{
    public AudioSource source;
    
    public void ClickMouse()
    {
        source.Play();
    }
}
