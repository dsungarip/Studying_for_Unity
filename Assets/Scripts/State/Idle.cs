using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : StateMachineBehaviour
{
	_09_21_MechanimAnimation player;
	// OnStateEnter�� ��ȯ�� ���۵ǰ� ���� �ý����� �� ���¸� ���ϱ� ������ �� ȣ��˴ϴ�.
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		player = animator.GetComponent<_09_21_MechanimAnimation>();
		Debug.Log("Idle���� ����");
	}

	// OnStateUpdate�� OnStateEnter�� OnStateExit �ݹ� ������ �� ������Ʈ �����ӿ��� ȣ��˴ϴ�.
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

	// OnStateExit�� ��ȯ�� ����ǰ� ���� �ý����� �� ���� �򰡸� ��ġ�� ȣ��˴ϴ�.
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		Debug.Log("Idle���� ����");
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
