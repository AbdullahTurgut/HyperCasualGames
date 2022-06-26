using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LedgeGenerate : MonoBehaviour
{
    public GameObject[] ledge;
    public int ledgeNum;
    public int ledgePos = 5;
    public bool creatingLedge = false;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (!creatingLedge)
        {
            creatingLedge = true;
            StartCoroutine(GenerateLedge());
        }
    }
    IEnumerator GenerateLedge()
    {
        ledgeNum = Random.Range(0, 7);
        Instantiate(ledge[ledgeNum], new Vector3(0, 0, ledgePos), Quaternion.identity);
        ledgePos += 1;
        Instantiate(ledge[0], new Vector3(0, 0, ledgePos), Quaternion.identity);
        ledgePos += 1;
        Instantiate(ledge[0], new Vector3(0, 0, ledgePos), Quaternion.identity);
        ledgePos += 1;
        yield return new WaitForSeconds(0.5f);
        creatingLedge = false;
    }
}
