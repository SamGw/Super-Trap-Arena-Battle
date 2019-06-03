using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sh_Nair : StateMachineBehaviour
{
    private Rigidbody2D rb2d;

    private float y;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb2d = animator.GetComponentInParent<Rigidbody2D>();
        if (rb2d.velocity.y < 0)
            y = -0.1f;
        else
            y = rb2d.velocity.y;
        rb2d.velocity = new Vector2(rb2d.velocity.x, y);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb2d = animator.GetComponentInParent<Rigidbody2D>();
        if (rb2d.velocity.y < 0)
            y += -0.05f;
        else
            y = rb2d.velocity.y;
        rb2d.velocity = new Vector2(rb2d.velocity.x, y);
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

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
