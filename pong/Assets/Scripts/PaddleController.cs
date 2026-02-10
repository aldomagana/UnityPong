using UnityEngine;

public class PaddleController : MonoBehaviour
{
    protected float speed = 5.0f;
    protected Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   protected virtual void FixedUpdate()
    {
        float input = GetInputAxis();
        rb.linearVelocity = new Vector2(0f, input * speed);
    
    }

    protected virtual float GetInputAxis()
    {
        return 0f;
    }
}
