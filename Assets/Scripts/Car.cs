using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public Rigidbody2D rb;
    public float minSpeed = 8.0f;
    public float maxSpeed = 12.0f;
    float speed;

    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);

    }

    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * speed * Time.fixedDeltaTime);
    }
}
