using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : StateMachineBehaviour
{
	_09_21_MechanimAnimation player;
	// OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		player = animator.GetComponent<_09_21_MechanimAnimation>();
		Debug.Log("Walk 시작");
	}

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		float time = animator.GetCurrentAnimatorStateInfo(0).normalizedTime;

		player.PlayerMove();
		player.PlayerRotate();
		if (player.target == null)
		{
			if(player.transform.position == player.end)
			{
				Debug.Log("나실행되니");
				animator.SetInteger("aniIndex", 0);
			}

		}
		else if(player.target != null)
		{
			float distance = Vector3.Distance(player.transform.position, player.target.position);
			if (player.transform.position == player.end)
			{
				animator.SetInteger("aniIndex", 2);
			}
			else
			{
				if (distance <= player.attackRange)
				{
					player.end = player.transform.position;
					animator.SetInteger("aniIndex", 2);
				}
			}
		}
	}

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		Debug.Log("Walk 종료");
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
