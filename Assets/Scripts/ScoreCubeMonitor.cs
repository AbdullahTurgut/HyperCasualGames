using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreCubeMonitor : MonoBehaviour
{
    public static int scoreNum;
    public GameObject scoreText;


  
    void Update()
    {
        scoreText.GetComponent<Text>().text = "SCORE : " + scoreNum;
    }
}
