using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMoveLR : MonoBehaviour
{
    public GameObject theRunner;
    public GameObject mainCam;
    public int xPos;
    public float zPos;

    void Start()
    {
        
    }

    
    void Update()
    {
        zPos = theRunner.gameObject.transform.position.z;
    }
    public void MoveRight()
    {
        if (xPos == 1)
        {
            xPos = 1;
        }
        else
        {
            xPos += 1;
        }
        theRunner.gameObject.transform.position = new Vector3(xPos, 1, zPos);
        mainCam.gameObject.transform.localPosition = new Vector3(xPos * -1, 8, -0.79f);

    }
    public void MoveLeft()
    {
        if (xPos == -1)
        {
            xPos = -1;
        }
        else
        {
            xPos -= 1;
        }
        theRunner.gameObject.transform.position = new Vector3(xPos, 1, zPos);
        mainCam.gameObject.transform.localPosition = new Vector3(xPos * -1, 8, -0.79f);
    }
}
