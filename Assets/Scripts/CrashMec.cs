using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CrashMec : MonoBehaviour
{
    public GameObject player;
    public GameObject backMusic;
    public GameObject splashBackGround;
    public GameObject finalScore;
    public AudioSource crushFX;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerObject"))
        {
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            backMusic.SetActive(false);
            crushFX.Play();
            player.GetComponent<CharMove>().enabled = false;
            finalScore.GetComponent<Text>().text = "FSCORE : " + ScoreCubeMonitor.scoreNum;
            PlayerPrefs.SetInt("LastScore", ScoreCubeMonitor.scoreNum);
            ScoreCubeMonitor.scoreNum = 0;
            finalScore.SetActive(true);
            splashBackGround.SetActive(true);
            splashBackGround.GetComponent<Animator>().Play("SplashFadeIn");
            StartCoroutine(ResetGame());
        }
    }

    IEnumerator ResetGame()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }
}
