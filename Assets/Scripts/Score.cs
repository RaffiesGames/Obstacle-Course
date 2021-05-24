using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int HitCount = 0;
    private void OnCollisionEnter(Collision other) 
    {
        if(!(other.gameObject.tag == "Hit"))
        {
            HitCount++;
            //Debug.Log(HitCount);
        }
    }
}
