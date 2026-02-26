using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 6f;

    private Rigidbody2D rb;
    private float lastCollisionTime;
    private float collisionCooldown = 0.1f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Start diagonally
        rb.linearVelocity = new Vector2(1f, 1f).normalized * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Prevent multiple bounces within a short time
        if (Time.time - lastCollisionTime < collisionCooldown)
            return;

        lastCollisionTime = Time.time;

        // Simple bounce: reverse the axis that hit
        if (Mathf.Abs(rb.linearVelocity.x) > Mathf.Abs(rb.linearVelocity.y))
        {
            // Hit a vertical wall (left/right)
            rb.linearVelocity = new Vector2(-rb.linearVelocity.x, rb.linearVelocity.y);
        }
        else
        {
            // Hit a horizontal wall (top/bottom)
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, -rb.linearVelocity.y);
        }
    }
}