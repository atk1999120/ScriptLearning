using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YearToSecond : MonoBehaviour
{
    public int year = 0;
    public void Start()
    {
        int answer = 0;
        year = Random.Range(1, 2021);
        answer = year * 365 * 24 * 60 * 60;
        Debug.Log(year +"‚Í" + answer);
    }  
}
