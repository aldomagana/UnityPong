using Unity.VisualScripting;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
   protected float MovemnetSpeed = 8f;
   protected Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float input = GetMovemnetInput();
        rb.velocity = new Vector2(0, input * MovemnetSpeed);

        float clampedY = Mathf.Clamp(transform.position.y, -7.5f, 7.5f);
    transform.position = new Vector3(transform.position.x, clampedY, transform.position.z);
    }

    protected virtual float GetMovemnetInput()
    {
        return 0f;
    }
}
