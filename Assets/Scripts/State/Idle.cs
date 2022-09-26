using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : StateMachineBehaviour
{
	_09_21_MechanimAnimation player;
	// OnStateEnter는 전환이 시작되고 상태 시스템이 이 상태를 평가하기 시작할 때 호출됩니다.
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		player = animator.GetComponent<_09_21_MechanimAnimation>();
		Debug.Log("Idle상태 시작");
	}

	// OnStateUpdate는 OnStateEnter와 OnStateExit 콜백 사이의 각 업데이트 프레임에서 호출됩니다.
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{

		if (player.transform.position != player.end)
		{
			if (player.target != null)
			{
				float distance = Vector3.Distance(player.transform.position, player.target.position);
				if(distance <= player.attackRange)
				{
					animator.SetInteger("aniIndex", 2);
				}
				else
				{
					animator.SetInteger("aniIndex", 1);
				}
				
			}
			else
			{
				animator.SetInteger("aniIndex", 1);
			}
		}
		else
		{
			if (player.target != null)
			{
				float distance = Vector3.Distance(player.transform.position, player.target.position);
				if (distance <= player.attackRange)
				{
					animator.SetInteger("aniIndex", 2);
				}
				else
				{
					animator.SetInteger("aniIndex", 1);
				}
			}
			else
			{
				animator.SetInteger("aniIndex", 0);
			}
		}
	}

	// OnStateExit은 전환이 종료되고 상태 시스템이 이 상태 평가를 마치면 호출됩니다.
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		Debug.Log("Idle상태 종료");
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
