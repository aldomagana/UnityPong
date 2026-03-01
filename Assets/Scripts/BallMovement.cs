using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private float speed = 6f;
    private Vector2 direction;
    private Rigidbody2D rb;
    private float lastCollisionTime;
    private float collisionCooldown = 0.2f;

    public float GetSpeed()
    {
        return speed;
    }
    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    public Vector2 GetDirection()
    {
        return direction;
    }
    public void SetDirection(Vector2 newDirection)
    {
        direction = newDirection.normalized;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = new Vector2(1f, 1f).normalized;
        rb.velocity = direction * speed;
    }

    void FixedUpdate()
    {
        rb.velocity = direction * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
       if (Time.time - lastCollisionTime < collisionCooldown)
        return;

    lastCollisionTime = Time.time;

    if (collision.gameObject.CompareTag("Paddle"))
    {
        // Simply reverse X direction
        direction = new Vector2(-direction.x, direction.y).normalized;
    }
    else
    {
        // Reflect off walls
        Vector2 normal = collision.contacts[0].normal;
        direction = Vector2.Reflect(direction, normal).normalized;

        // Prevent shallow angles on wall hits
        if (Mathf.Abs(direction.y) < 0.3f)
        {
            direction.y = 0.3f * Mathf.Sign(direction.y);
            direction = direction.normalized;
        }
    }

    rb.velocity = direction * speed;
    }
}