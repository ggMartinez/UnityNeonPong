using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] float startSpeed;
    [SerializeField] float extraSpeed;
    [SerializeField] float maxExtraSpeed;
    [SerializeField] Rigidbody2D rigidBody;
    public bool PlayerOneStart = true;    


    int hitCounter = 0;

    void Start(){
        StartCoroutine(Launch());
    }

    void restartBall(){
        rigidBody.velocity = new Vector2(0f,0f);
        transform.position = new Vector2(0f,0f);
    }
    public IEnumerator Launch(){
        restartBall();
        hitCounter = 0;
        yield return new WaitForSeconds(1);
        if (PlayerOneStart) MoveBall(new Vector2(-1,0));
        if (!PlayerOneStart) MoveBall(new Vector2(1,0));
    }
    public void MoveBall(Vector2 direction){
        direction = direction.normalized;
        float ballSpeed = startSpeed + hitCounter * extraSpeed;
        rigidBody.velocity = direction * ballSpeed;

    }

    public void IncreaseHitNumber(){
        if (hitCounter * extraSpeed < maxExtraSpeed){
            hitCounter++;
        } 
    }
   
    
}
