using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 3f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Start ball moving diagonally
        rb.linearVelocity = new Vector2(speed, speed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Only bounce off walls
        if (collision.gameObject.CompareTag("Wall"))
        {
            // Reverse Y direction
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, -rb.linearVelocity.y);
        }
    }
}

