using Ink.Parsed;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionUp : MonoBehaviour
{
    public float force = 2f;  
    public float propulsionDuration = 2f;
    public float delayDuration = 4f;

    [SerializeField] private ParticleSystem launchSoda;
    private List<Rigidbody> currentObjects = new();
    private FirstPersonController player = null;

    public void Start()
    {
        AddForceToObjects();
    }

    public void AddForceToObjects()
    {
        Debug.Log("Launch");
        Vector3 currentForce = transform.up * force;
        for(int i = 0; i < currentObjects.Count; i++) 
        {
            if (currentObjects[i])
                currentObjects[i].AddForce(currentForce);
        }

        if(player)
        {
            player.ProcessForce(currentForce);
        }

        Invoke("AddForceToObjects", delayDuration);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject + " has entered");
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb) 
        {
            currentObjects.Add(rb);
        }

        FirstPersonController plyr = other.GetComponent<FirstPersonController>();
        if (plyr)
        {
            player = plyr;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (currentObjects.Contains(rb))
        {
            currentObjects.Remove(rb);
        }

        FirstPersonController plyr = other.GetComponent<FirstPersonController>();
        if (plyr)
        {
            player = null;
        }
    }
}

