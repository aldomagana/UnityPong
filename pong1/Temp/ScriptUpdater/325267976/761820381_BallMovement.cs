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
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
  Vector2 normal = collision.contacts[0].normal;
    
  // Reflect velocity based on surface angle
  rb.linearVelocity = Vector2.Reflect(rb.linearVelocity, normal);
    }
}