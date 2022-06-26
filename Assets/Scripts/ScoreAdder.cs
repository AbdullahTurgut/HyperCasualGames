using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAdder : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerObject"))
        {
            ScoreCubeMonitor.scoreNum += 10;
        }
    }
}
