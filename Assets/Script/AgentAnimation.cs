using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentAnimation : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void PlayAnimation(Vector2 movementInput)
    {
        animator.SetBool("isWalking", movementInput.magnitude > 0);

    }
}
