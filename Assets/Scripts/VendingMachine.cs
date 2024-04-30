using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class VendingMachine : MonoBehaviour
{
    [SerializeField] private Animator anim;

    public void ShakeMachine()
    {
        anim.SetBool("shake", true);
    }

    public void StopMachine()
    {
        anim.SetBool("shake", false);
    }
}
