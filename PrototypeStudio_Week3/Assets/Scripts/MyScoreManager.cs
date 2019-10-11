﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyScoreManager : MonoBehaviour
{
    public ScoreStorer scoresctorer;
    public int Score;
    private Text scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = Score.ToString();
        scoresctorer.score = Score;
    }
}
