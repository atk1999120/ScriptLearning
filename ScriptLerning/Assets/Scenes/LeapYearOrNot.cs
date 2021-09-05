using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeapYearOrNot : MonoBehaviour
{
   public int i = 0;

    private void Start()
    {
        i = Random.Range(1, 10000);
        if (i % 4 == 0)
        {
            Debug.Log(i+"うるう年である");
            if (i % 100 == 0)
            {
                Debug.Log(i+"うるう年でない");
            }
        }
        else
        {
            Debug.Log(i + "うるう年ではない");
        }
        if (i % 4 == 0 && i % 100 == 0 && i % 400 == 0)
        {
            Debug.Log(i+"うるう年である");
        }
       
    }
}
