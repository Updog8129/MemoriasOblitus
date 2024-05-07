using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoCase : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void StartAnimation()
    {
        animator.SetBool("open", true);
    }

    public void StopAnimation()
    {
        animator.SetBool("open", false);
    }
}
