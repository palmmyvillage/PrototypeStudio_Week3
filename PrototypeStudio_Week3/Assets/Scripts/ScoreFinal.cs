using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreFinal : MonoBehaviour
{

    public ScoreStorer scorestorer;

    public int score; 
    
    // Start is called before the first frame update
    void Start()
    {
        scorestorer = GameObject.Find("ScoreStorer").GetComponent<ScoreStorer>();
    }

    // Update is called once per frame
    void Update()
    {
        score = scorestorer.score;

        GetComponent<Text>().text = score.ToString();
    }
}
