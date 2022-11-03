using System;
using UnityEngine;

public class Bullet : MonoBehaviour

{
    public float speed = 2300f;
    public Rigidbody2D rb;
    private void Start()
    {
        rb.velocity = transform.right * speed;
    }
    
}
