using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float forceSize;

    private Vector3 forceDirection;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");

        forceDirection = new Vector3(inputHorizontal, 0, inputVertical);
        forceDirection.Normalize();
    }

    private void FixedUpdate()
    {
        Vector3 force = forceDirection * forceSize;
        rb.AddForce(force);
    }
}
