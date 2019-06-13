using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrototypeManager : MonoBehaviour
{
    int score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
        score = PlayerPrefs.GetInt("Score");
        scoreText.GetComponentInChildren<Text>().text = "Score: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
