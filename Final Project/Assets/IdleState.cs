using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : StateMachineBehaviour
{
    float timer;
    Transform player;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timer = 0;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timer += Time.deltaTime;
        int num = Random.Range(2, 6);
        float distance = Vector2.Distance(player.position, animator.transform.position);
        if (distance > 10 && distance < 20 && timer > num)
            animator.SetBool("flamethrower", true);
       
        //distance conditions

        
        
        if(distance > 20 && timer > num)
            animator.SetBool("fireball", true);

        if (distance < 10 && timer > num)
            
            animator.SetBool("footslam", true);
       
        //if (GameManager.gameManager._playerHealth.Health == 0)
        //{
        //    animator.SetBool("fireball", false);
        //    animator.SetBool("flamethrower", false);
        //    animator.SetBool("footslam", false);
        //    animator.enabled = false;
        //}
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
