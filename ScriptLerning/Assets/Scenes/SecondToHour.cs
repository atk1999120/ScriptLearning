using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondToHour : MonoBehaviour
{
    public int Sec = 0;
    public void Start()
    {
        int Seconds = 0;
        int Minutes = 0;
        int Hours = 0;
        if (Sec >= 60)
        {
            while(Sec < 60)
            {
                Minutes++;
                Seconds = Sec - 60;
            }
        }
        if (Minutes >= 60)
        {
            Hours++;
            Minutes = Minutes - 60;
        }
        if (Hours >= 24)
        {
            Hours = Hours - 24;
        }
        Debug.Log(Sec + "‚Í" + Hours + ":" + Minutes + ":" + Seconds);
    }
}

