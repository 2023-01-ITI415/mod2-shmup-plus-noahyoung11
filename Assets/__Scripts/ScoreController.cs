using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [Header("Set Dynamically")]
    public Text scoreGT;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        scoreGT = scoreGO.GetComponent<Text>();
        scoreGT.text = "0";
    }

    public void ScoreFlag(int scoreIncrease){
        int score = int.Parse(scoreGT.text);
        score += scoreIncrease;
        scoreGT.text = score.ToString();
        if(score > HighScore.score){
            HighScore.score = score;
        }
    }
}
