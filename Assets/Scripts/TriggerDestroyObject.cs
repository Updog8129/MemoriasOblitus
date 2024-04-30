using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerDestroyObject : MonoBehaviour
{
    public UnityEvent triggerEventIn;
    public UnityEvent triggerEventOut;

    public int IDCheck;


    public void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<CheckID>())
        {
            if(other.GetComponent<CheckID>().ID == IDCheck)
            {
                triggerEventIn.Invoke();
                Destroy(other.gameObject);
            }
        }
    }
}
