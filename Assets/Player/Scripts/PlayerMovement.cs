using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float racketSpeed;
    [SerializeField] Rigidbody2D rigidBody;
    private float movement;

    Vector2 racketDirection;

    void Update(){
       racketDirection = new Vector2(0f, movement).normalized;
    }

    void FixedUpdate(){
        rigidBody.velocity = racketDirection * racketSpeed;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>().y;
    }

}
