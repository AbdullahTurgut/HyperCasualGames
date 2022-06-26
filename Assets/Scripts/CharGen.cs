using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharGen : MonoBehaviour
{
    public GameObject[] charSelect;
    public int charNum;
    // Start is called before the first frame update
    void Start()
    {
        charNum = Random.Range(0, 3);
        charSelect[charNum].SetActive(true);
    }

    
}
