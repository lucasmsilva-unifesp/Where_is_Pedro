using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentMover : MonoBehaviour
{
    private Rigidbody2D rigidBody;

    [SerializeField]
    private float maxSpeed = 0.9F, acceleration = 6, desacceleration = 13;

    [SerializeField]
    private float currentSpeed = 0;

    private Vector2 oldMovementInput;

    public Vector2 Movementinput { get; set; }

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Movementinput.magnitude > 0 && currentSpeed >= 0)
        {
            oldMovementInput = Movementinput;
            currentSpeed += acceleration * maxSpeed * Time.deltaTime;
        }
        else
        {
            currentSpeed -= desacceleration * maxSpeed * Time.deltaTime;
        }

        currentSpeed = Math.Clamp(currentSpeed, 0, maxSpeed);
        rigidBody.velocity = oldMovementInput * currentSpeed;
    }
}
