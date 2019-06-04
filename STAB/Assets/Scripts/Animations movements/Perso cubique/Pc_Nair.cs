using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pc_Nair : StateMachineBehaviour
{
    public GameObject Shoe;
    private Rigidbody2D rb2d;
    private Transform tr;
    
    //OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb2d = animator.GetComponentInParent<Rigidbody2D>();
        
        rb2d.velocity = new Vector2(0, 0.3f);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb2d = animator.GetComponentInParent<Rigidbody2D>();

        rb2d.velocity = new Vector2(0, 0.3f);
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        tr = animator.GetComponentInParent<Transform>();
        float posX;
        if (tr.localScale.x > 0)
            posX = tr.position.x + 0.37f;
        else
            posX =tr.position.x - 0.37f;

        GameObject Shoe1 = Instantiate(Shoe, new Vector3(posX, tr.position.y - 0.15f, 0f) , new Quaternion());
        ShoeMovements s = Shoe1.GetComponent<ShoeMovements>();
        
        tr = animator.GetComponentInParent<Transform>();
        s.direction = tr.localScale.x;
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
