using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageButtonController : MonoBehaviour
{
    Animator animator;

    public void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void SetParameters()
    {
        if (animator.GetBool("isOn"))
        {
            animator.SetBool("isOn", false);
        }
        else
        {
            animator.SetBool("isOn", true);
        }
    }
}
