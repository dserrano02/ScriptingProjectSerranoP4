using UnityEngine;
using System.Collections;


public class ForLoop : MonoBehaviour
{
    int cupsInTheSink = 4;


    void Start()
    {
        while (cupsInTheSink > 0)
        {
            Debug.Log("I've washed a cup!");
            cupsInTheSink--;
        }
    }
}

