using System;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private float speed = 3f;
    private Vector2 direction = new Vector2(1f, 1f);

    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = direction.normalized;
        
    }

    void FixedUpdate()
    {
        rb.linearVelocity = direction * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("TopWalls"))
        {
            direction = new Vector2(direction.x, -direction.y);
        }

        if (collision.gameObject.CompareTag("Paddle"))
        {
            direction = new Vector2(-direction.x, direction.y);
        }
}
    public float GetSpeed()
    {
        return speed;
    }

    public void SetSpeed(float newSpeed)
    {
        speed = Mathf.Max(0f, newSpeed);
    }

    public Vector2 GetDirection()
    {
        return direction;
    }

    public void SetDirection(Vector2 newDirection)
    {
        if (newDirection != Vector2.zero)
        {
            direction = newDirection.normalized;
        }
    }
}

