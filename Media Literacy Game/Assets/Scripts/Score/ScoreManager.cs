using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreText;
    public int score = 0;
    public static int staticScore = 0;
    void Start()
    {
        staticScore = score;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = staticScore.ToString();
    }

    public void updateScore(int score)
    {
        this.score += score;
    }
}
