using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMove : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float timeDelay;
    public float increaseSpeed;
    public bool addingSpeed;


    void Start()
    {
        timeDelay = 1;
        increaseSpeed = 0.05f;
    }

    void Update()
    {
        transform.Translate(Vector3.forward *Time.deltaTime*moveSpeed,Space.World);
        if (!addingSpeed)
        {
            addingSpeed = true;
            StartCoroutine(IncreaseTheSpeed());
        }
    }

    IEnumerator IncreaseTheSpeed()
    {
        yield return new WaitForSeconds(timeDelay);
        moveSpeed += increaseSpeed;
        addingSpeed = false;
    }
}
