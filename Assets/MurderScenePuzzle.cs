using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class MurderScenePuzzle : MonoBehaviour
{
    public int placeCount = 0;
    public UnityEvent events;

    void Update()
    {
        if (placeCount >= 4)
        {
            events.Invoke();
        }
    }

    public void AddPoint()
    {
        placeCount++;
    }
}
