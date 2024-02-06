using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float racketSpeed;
    [SerializeField] Rigidbody2D rigidBody;

    Vector2 racketDirection;

    void Update(){
        float directionY = Input.GetAxis("Vertical");
        racketDirection = new Vector2(0f, directionY).normalized;
    }

    void FixedUpdate(){
        rigidBody.velocity = racketDirection * racketSpeed;;
    }
}
