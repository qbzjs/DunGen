using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitAnimator : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private void Start()
    {
        if (TryGetComponent<MoveAction>(out MoveAction moveAction))
        {
            moveAction.OnMoveStart += MoveAction_OnMoveStart;
            moveAction.OnMoveStop += MoveAction_OnMoveStop;
        }

        if (TryGetComponent<ShootAction>(out ShootAction shootAction))
        {
            shootAction.OnShoot += ShootAction_OnShoot;
        }
    }

    private void MoveAction_OnMoveStart(object sender, EventArgs e) 
    {
        animator.SetBool("IsWalking", true);
    }

    private void MoveAction_OnMoveStop(object sender, EventArgs e) 
    {
        animator.SetBool("IsWalking", false);
    }

    private void ShootAction_OnShoot(object sender, EventArgs e) 
    {
        animator.SetTrigger("Shoot");
    }
}