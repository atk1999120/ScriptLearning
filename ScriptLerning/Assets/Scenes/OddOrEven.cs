using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int i = 0;

   void start()
   {
       if(i % 2 == 1)
       {
            Debug.Log(i + "‚ÍŠï”‚Å‚·");
       }
      else
      {
         Debug.Log(i + "‚Í‹ô”‚Å‚·");
      }
   }
}
