using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    int[] playerScore;

    [SerializeField] TextMeshProUGUI[] playerScoreText;

    void Start()
    {
        playerScore = new int[2];
        playerScore[0] = 0;
        playerScore[1] = 0;
        playerScoreText[0].text = playerScore[0].ToString();
        playerScoreText[1].text = playerScore[1].ToString();
    }

    public void Goal(int player){
        playerScore[player-1]++;
        playerScoreText[player-1].text = playerScore[player-1].ToString();
    }
}
