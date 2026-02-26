using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed=5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(3f, 3f);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector2 normal = collision.contacts[0].normal;
        Vector2 newVel = Vector2.Reflect(rb.linearVelocity, normal);

        // Keep constant speed (prevents slow “stick” / energy loss)
        rb.linearVelocity = newVel.normalized * speed;
    // Update is called once per frame        
    
    }
}