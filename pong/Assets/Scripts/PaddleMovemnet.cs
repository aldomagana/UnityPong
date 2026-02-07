using UnityEngine;

public class PaddleMovemnet : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");

        transform.position += new Vector3(0f, vertical * speed * Time.deltaTime, 0f);
    }
}
