using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovemnet: MonoBehaviour
{
    public float speed = 5.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, vertical * speed * Time.deltaTime, 0);
    }
}
