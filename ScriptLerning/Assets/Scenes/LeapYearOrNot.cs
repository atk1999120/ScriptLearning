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
            Debug.Log("���̔N�͂��邤�N�ł�");
        }
        else
        {
            Debug.Log("���̔N�͂��邤�N�ł͂���܂���");
        }
    }
}
