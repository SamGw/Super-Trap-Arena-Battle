using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sh_Sair : StateMachineBehaviour
{
    private Rigidbody2D rb2d;
    private PlayerMovements p;
    private float x;
    //OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb2d = animator.GetComponentInParent<Rigidbody2D>();
        p = animator.GetComponentInParent<PlayerMovements>();
        p.hitStun = true;
        if (p.transform.localScale.x < 0)
            x = -6f;
        else
            x = 6f;
        rb2d.velocity = new Vector2(x, rb2d.velocity.y);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        p = animator.GetComponentInParent<PlayerMovements>();
        p.hitStun = false;
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
