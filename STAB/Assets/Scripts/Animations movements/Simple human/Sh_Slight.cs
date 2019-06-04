using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sh_Slight : StateMachineBehaviour
{
    public GameObject Bp;
    
    private Rigidbody2D rb2d;
    private Transform tr;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb2d = animator.GetComponentInParent<Rigidbody2D>();
        tr = rb2d.GetComponentInParent<Transform>();

        float posX;
        float velX;
        if (tr.localScale.x > 0)
        {
            posX = tr.position.x + 0.4f;
            velX = rb2d.velocity.x + 4f;
        }
        else
        {
            posX = tr.position.x - 0.4f;
            velX = rb2d.velocity.x - 4f;
        }
        
        GameObject Bp2 = Instantiate(Bp, new Vector3(posX, tr.position.y - 0.396f, 0), new Quaternion());
        BackpackMovements Bp2move = Bp2.GetComponent<BackpackMovements>();

        Bp2move.initialVelocityX = velX;
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
