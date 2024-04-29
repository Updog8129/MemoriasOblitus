using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerMurderPuzzle: MonoBehaviour
{
    public UnityEvent triggerEventIn;

    public int IDToLookFor;
    public int ID;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PickUp")
        {
            ID = other.gameObject.GetComponent<PickUpID>().GetID();

            if(IDToLookFor == ID)
            {
                triggerEventIn.Invoke();
                Destroy(other);
            }
        }
    }
}
