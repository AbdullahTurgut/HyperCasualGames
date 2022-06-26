using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchFunctions : MonoBehaviour
{
    public GameObject platOne;
    public GameObject platSec;
    public GameObject platThird;
    public bool activePlat = false;
    public AudioSource platActiveFX;
    public void PlatOne()
    {
        if (!activePlat)
        {
            activePlat = true;
            platActiveFX.Play();
            platOne.SetActive(true);
            StartCoroutine(PlatOneReset());
        }
        
    }
    public void PlatSec()
    {
        if (!activePlat)
        {
            activePlat = true;
            platActiveFX.Play();
            platSec.SetActive(true);
            StartCoroutine(PlatSecReset());
        }
    }
    public void PlatThird()
    {
        if (!activePlat)
        {
            activePlat = true;
            platActiveFX.Play();
            platThird.SetActive(true);
            StartCoroutine(PlatThirdReset());
        }
    }

    IEnumerator PlatOneReset()
    {
        yield return new WaitForSeconds(0.5f);
        platOne.SetActive(false);
        activePlat = false;
    }

    IEnumerator PlatSecReset()
    {
        yield return new WaitForSeconds(0.5f);
        platSec.SetActive(false);
        activePlat = false;
    }
    IEnumerator PlatThirdReset()
    {
        yield return new WaitForSeconds(0.5f);
        platThird.SetActive(false);
        activePlat = false;
    }

}
