using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbCatch : MonoBehaviour
{
    public AudioSource orbCatch;

    void OnTriggerEnter(Collider other)
    {
        orbCatch.Play();
        if (other.CompareTag("RedOrb"))
        {
            ScoreUpdater.orbScore += 10;
            ScoreUpdater.orbCount += 1;
        }
        if (other.CompareTag("BlueOrb"))
        {
            ScoreUpdater.orbScore += 20;
        }
        if (other.CompareTag("GreenOrb"))
        {
            ScoreUpdater.orbScore += 30;
        }
        ScoreUpdater.orbCount += 1;
        other.gameObject.SetActive(false);
    }

}
