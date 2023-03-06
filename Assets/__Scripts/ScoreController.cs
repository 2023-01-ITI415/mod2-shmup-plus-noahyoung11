using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [Header("Set Dynamically")]
    public Text scoreGT;
    public int score = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        scoreGT = scoreGO.GetComponent<Text>();
        scoreGT.text = "0";
    }

    void Update(){
        scoreGT.text = score.ToString();
        if(score > HighScore.score){
            HighScore.score = score;
        }
    } 
}
