using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour
{
    public Text scoreText;
    public Text orbCountText;

    public static int orbScore;
    public static int orbCount;
    void Update()
    {
        scoreText.text = "SCORE : " + orbScore;
        orbCountText.text = "ORBS : " + orbCount;
    }

   
}
