using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorB : MonoBehaviour
{
    private Animator animator;

    private bool doorController;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        doorController = true;
    }

    public void DoorController()
    {
        if (doorController)
        {
            animator.SetTrigger("DoorOpening");
        }
        else
        {
            animator.SetTrigger("DoorClosing");
        }

        doorController = !doorController;
    }
}
