using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    float speed;

    [SerializeField]
    Rigidbody2D body;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        if (Mathf.Abs(xInput) > 0.1)
        {
            body.velocity = new Vector2 (xInput * speed, body.velocity.y);
        }

        if (Mathf.Abs(yInput) > 0.1)
        {
            body.velocity = new Vector2(body.velocity.x, yInput * speed);
        }


    }



}
