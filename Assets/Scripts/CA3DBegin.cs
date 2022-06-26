using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CA3DBegin : MonoBehaviour
{
    public GameObject _Player;
    public GameObject mainLogo;
    public GameObject backMusic;
    public GameObject gameLogo;
    public GameObject tapToBegin;
    public GameObject tapBtn;
    public GameObject splashBackGround;
    public GameObject countdownText;
    public GameObject lastScore;
    void Start()
    {
        StartCoroutine(StartupGame());
    }

    IEnumerator StartupGame()
    {
        yield return new WaitForSeconds(1);
        mainLogo.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        mainLogo.SetActive(false);
        gameLogo.SetActive(true);
        tapToBegin.SetActive(true);
        tapBtn.SetActive(true);
        lastScore.SetActive(true);
    }

    public void TapToStart()
    {
        tapBtn.SetActive(false);
        gameLogo.SetActive(false);
        tapToBegin.SetActive(false);
        lastScore.SetActive(false);
        splashBackGround.GetComponent<Animator>().Play("SplashFadeOut2");
        StartCoroutine(BeginTheGame());
    }

    IEnumerator BeginTheGame()
    {
        yield return new WaitForSeconds(1);
        countdownText.SetActive(true);
        yield return new WaitForSeconds(1);
        countdownText.GetComponent<Text>().text = "2";
        yield return new WaitForSeconds(1);
        countdownText.GetComponent<Text>().text = "1";
        yield return new WaitForSeconds(1);
        countdownText.SetActive(false);
        countdownText.GetComponent<Text>().text = "3";
        backMusic.SetActive(true);
        splashBackGround.SetActive(false);
        _Player.GetComponent<CharMove>().enabled = true;
       
    }
}
