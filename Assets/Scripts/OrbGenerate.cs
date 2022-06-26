using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbGenerate : MonoBehaviour
{
    public GameObject[] orbFall;
    public bool genOrb=false;
    public int orbLoc;
    public int orbCol;
    public float xPos;
    
    void Update()
    {
        if (!genOrb)
        {
            genOrb = true;
            orbLoc = Random.Range(1, 4);//1 ile 4 arasýnda rastgele sayý seçicek ve buna göre toplarýn çýkýcaðý yeri ayarlýycaz
            orbCol = Random.Range(0, 3);//burda ise orbFall ile alýcaðýmýz dizide 0,2 arasý element olucaðý için randomu öyle yaptýk
            if (orbLoc == 1)
            {
                xPos = -1.71f;
            }
            if (orbLoc == 2)
            {
                xPos = 0.08f;
            }
            if (orbLoc == 3)
            {
                xPos = 1.8f;
            }
            StartCoroutine(OrbFalling());
        }

        IEnumerator OrbFalling()
        {
            Instantiate(orbFall[orbCol], new Vector3(xPos, 10, 0), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
            genOrb = false; 
        }
    }
}
