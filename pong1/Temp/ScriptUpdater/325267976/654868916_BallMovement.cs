using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 6f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Start diagonally
        rb.linearVelocity = new Vector2(1f, 1f).normalized * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 normal = collision.contacts[0].normal;

        // Reflect velocity based on surface angle
        Vector2 newVelocity = Vector2.Reflect(rb.linearVelocity, normal);

        // Keep constant speed
        rb.linearVelocity = newVelocity.normalized * speed;

        // Tiny push away from wall to prevent sticking
        rb.position += normal * 0.01f;
    }
}