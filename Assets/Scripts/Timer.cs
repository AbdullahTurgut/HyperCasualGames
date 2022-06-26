using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timeDisplay;
    public bool countingDown = false;
    public int currentSeconds = 30;
    public bool isZero = false;
    public GameObject splashBackGround;
    public GameObject bgm;
    public GameObject globalScripts;
    public GameObject tapPlayBttn;
    public GameObject finalScore;
    public GameObject finalOrbs;
    public GameObject tapToBeginText;


    void Update()
    {
        if (!isZero)
        {
            if (!countingDown && !isZero)
            {
                countingDown = true;
                StartCoroutine(SubtractSecond());
            }
        }
        if(isZero == true)
        {
            finalScore.GetComponent<Text>().text = "SCORE : " + ScoreUpdater.orbScore;
            finalOrbs.GetComponent<Text>().text = "ORBS : " + ScoreUpdater.orbCount;
            StartCoroutine(GameOver());
        }
    }

    IEnumerator SubtractSecond()
    {
        yield return new WaitForSeconds(1);
        currentSeconds -= 1;
        if(currentSeconds == 0)
        {
            isZero = true;

        }
        timeDisplay.text = "TIME : " + currentSeconds;
        countingDown = false;
    }

    IEnumerator GameOver()
    {
        splashBackGround.SetActive(true);
        splashBackGround.GetComponent<Animator>().Play("SplashFadeIn");
        bgm.SetActive(false);
        globalScripts.GetComponent<OrbGenerate>().enabled = false;
        yield return new WaitForSeconds(1.5f);
        finalScore.SetActive(true);
        finalOrbs.SetActive(true);
        tapToBeginText.SetActive(true);
        tapPlayBttn.SetActive(true);
        currentSeconds = 31;
        isZero = false;
        ScoreUpdater.orbScore = 0;
        ScoreUpdater.orbCount = 0;
        yield return new WaitForSeconds(0.3f);
        globalScripts.GetComponent<Timer>().enabled = false;
    }
}
