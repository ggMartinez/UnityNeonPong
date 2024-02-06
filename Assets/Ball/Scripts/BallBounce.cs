using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{

    [SerializeField] BallMovement ballMovement;
    [SerializeField] ScoreManager scoreManager;
    [SerializeField] private SoundPlayer soundPlayer;
    [SerializeField] GameObject explosionPrefab;
    [SerializeField] GameObject bigExplosionPrefab;

    void bounce(Collision2D collider){
        Vector3 ballPosition = transform.position;
        Vector3 racketPosition = collider.transform.position;
        float racketHeight = collider.collider.bounds.size.y;

        float positionX;
        if (collider.gameObject.name == "RacketPlayer")
            positionX = 1;
        else
            positionX = -1;
        float positionY = (ballPosition.y - racketPosition.y) / racketHeight;

        ballMovement.IncreaseHitNumber();
        ballMovement.MoveBall(new Vector2(positionX,positionY));
    
    }

    void OnCollisionEnter2D(Collision2D collider){
        if(collider.gameObject.tag == "Player"){
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            bounce(collider);
        }
    
        if(collider.gameObject.tag == "LeftBorder"){
            Instantiate(bigExplosionPrefab, transform.position, Quaternion.identity);
            scoreManager.PlayerTwoGoal();
            ballMovement.PlayerOneStart = true;
            StartCoroutine(ballMovement.Launch());

        }

        if(collider.gameObject.tag == "RightBorder"){
            Instantiate(bigExplosionPrefab, transform.position, Quaternion.identity);
            scoreManager.PlayerOneGoal(); 
            ballMovement.PlayerOneStart = false;
            StartCoroutine(ballMovement.Launch());


        }

        playSound(collider);
    }

    void playSound(Collision2D collider){
        if(collider.gameObject.tag != "LeftBorder" && collider.gameObject.tag != "RightBorder")
            soundPlayer.PlaySound("Bounce");
        if(collider.gameObject.tag == "LeftBorder" || collider.gameObject.tag == "RightBorder")
            soundPlayer.PlaySound("Explode");
    }
}
