using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeapYearOrNot : MonoBehaviour
{
    public static bool IsLeapYear(int year)
    {
        int i = i;
        if (i % 4 == 0 && i % 400 == 0)
        {
            Debug.Log("この年はうるう年です");
        }
        else
        {
            Debug.Log("この年はうるう年ではありません");
        }
    }
}
