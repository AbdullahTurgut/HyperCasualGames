using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LastScoreScripts : MonoBehaviour
{
    public GameObject lastScore;
    public int _lastScore;
    void Start()
    {
        _lastScore = PlayerPrefs.GetInt("LastScore");
        lastScore.GetComponent<Text>().text = "LAST SCORE : " + _lastScore;
    }

}
