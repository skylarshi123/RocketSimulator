using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RocketThruster : MonoBehaviour
{
    [SerializeField] private float thrustForce = 4f;
    [SerializeField] private float speedLimit = 10f;
    [SerializeField] private float thrustTorque = 1f;
    [SerializeField] private float threshold = 10f;
    [SerializeField] private float goodAngle = 5f;

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
        Vector3 screenPos = Camera.main.WorldToViewportPoint(transform.position);
        if (screenPos.x > 1)
        {
            screenPos.x = 0;
        }
        else if (screenPos.x < 0)
        {
            screenPos.x = 1;
        }

        transform.position = Camera.main.ViewportToWorldPoint(screenPos);
        //space
        if (inputSpace) rb.AddForce(transform.up * thrustForce);

        //left right
        rb.AddTorque(-inputVector.x * thrustTorque);

        if (rb.velocity.magnitude > speedLimit)
        {
            rb.velocity = rb.velocity.normalized * speedLimit;
        }
        //check position, to make it teleport left and right
    }

    void OnThrustUp(InputValue val)
    {
        inputSpace = val.Get<float>() > 0.5f;
    }

    void OnThrustDirection(InputValue val)
    {
        inputVector = val.Get<Vector2>();
    }


    void OnCollisionEnter2D(Collision2D collision)
    {

        Vector2 ImageDirection = transform.up;
        Vector2 GlobalY = new Vector2(0, 1);
        float angle = Vector2.Angle(ImageDirection, GlobalY);
        bool correctAngle = angle < goodAngle;
        bool correctVelocity = collision.relativeVelocity.magnitude < threshold;
        bool correctLanding = collision.gameObject.CompareTag("Ground");
        if (correctAngle && correctLanding && correctVelocity)
        {
            //advance to next level
            //UI page, score, etc
            Debug.Log(rb.velocity.magnitude);
            Debug.Log("Passed");
        }
        else
        {
            //failed, reset the game to home page
            Debug.Log("Failed");
        }
    }
}

