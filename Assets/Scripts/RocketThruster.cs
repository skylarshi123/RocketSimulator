using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RocketThruster : MonoBehaviour
{
    [SerializeField] private float thrustForce = 4f;
    [SerializeField] private float speedLimit = 10f;
    private Rigidbody2D rb;
    bool inputSpace;
    private Vector2 inputVector;
    //private float inputValue;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void  Update()
    {
        //space
        if (inputSpace) rb.AddForce(Vector2.up * thrustForce);

        //left right
        rb.addForce(inputVector * thrustForce);

        if (rb.velocity.magnitude > speedLimit)
        {
            rb.velocity = rb.velocity.normalized * speedLimit;
        }
    }

    void OnThrustUp(InputValue val)
    {
        inputSpace = val.Get<float>() > 0.5f;
    }

    void OnThrustDirection(InputValue val)
    {
        inputVector = val.Get<Vector2>(); 
    }
}

