using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    int playerOneScore = 0;
    int playerTwoScore = 0;

    [SerializeField] TextMeshProUGUI playerOneScoreText;
    [SerializeField] TextMeshProUGUI playerTwoScoreText;

    public void PlayerOneGoal(){
        playerOneScore++;
        playerOneScoreText.text = playerOneScore.ToString();
    }

    public void PlayerTwoGoal(){
        playerTwoScore++;
        playerTwoScoreText.text = playerTwoScore.ToString();
    }

}
