using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float gravity = 1.964f;
    public float stepGravity = 0.1964f; 

    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // движение вправо
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        if(gravity == 0f){gravity = stepGravity;}
    }
}