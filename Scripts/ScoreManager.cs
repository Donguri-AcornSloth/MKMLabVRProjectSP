using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int basicScore = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = "Score : " + LogData.score;
    }

    public void AddScore()
    {
        LogData.score += basicScore;
    }

    public static int getScore()
    {
        return LogData.score;
    }
}
