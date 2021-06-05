using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 4f;
    public WheelRotation rotation;

    private Rigidbody2D rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        HandleMovement();
        CheckWheelRotation();
    }

    private void HandleMovement()
    {
        float h = Input.GetAxisRaw("Horizontal");

        rigid.velocity = new Vector2(h * movementSpeed, rigid.velocity.y);
    }

    private void CheckWheelRotation()
    {
        if (rigid.velocity.x > 0)
        {
            rotation.RightWheelRotation();
        }
        else if (rigid.velocity.x < 0)
        {
            rotation.LeftWheelRotation();
        }
        else
        {
            rotation.StopWheelRotation();
        }
    }
    
}
