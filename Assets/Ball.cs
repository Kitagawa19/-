using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce((transform.right + transform.forward) * speed,
            ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
