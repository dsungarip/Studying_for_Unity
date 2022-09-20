using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _09_20_AnimationEvent : MonoBehaviour
{
    delegate void DoEvent();
    public Animator anim;
    float duration;
    DoEvent doEvent;
    int callCount;
    int refCount;

    void Start()
    {
        doEvent = null;
        callCount= 0;
        refCount = 0;
        AnimatorClipInfo[] clipInfos = anim.GetCurrentAnimatorClipInfo(0);
  //      Debug.Log($"�ִϸ��̼� Ŭ���� ������ �� {clipInfos.Length} ��");
        
  //      foreach(AnimatorClipInfo one in clipInfos)
		//{
  //          Debug.Log($"{one.clip.name}�� ���̴� {one.clip.length} �� �Դϴ�.");
		//}

    }

    public void MoveAnimEvent()
	{
        Debug.Log("MoveAnimEvent �Լ� ȣ��");
	}
    
    void Update()
    {
        // GetCurrentAnimatorStateInfo(0).IsName("Move") : anim�� ���°� Move���� bool��ȯ
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Move"))
        {
            // GetCurrentAnimatorStateInfo(0).normalizedTime : �ִϸ��̼��� �ð��� 0~1�� ����
            duration = anim.GetCurrentAnimatorStateInfo(0).normalizedTime % 1f;

            //refCount : �ִϸ��̼��� ���Ƚ���� ������.
            refCount = (int)anim.GetCurrentAnimatorStateInfo(0).normalizedTime;


            //�ִϸ��̼� ����ð��� 80% �̻� && �� Count���� ���ٸ�
            if (duration >= 0.8f && refCount - callCount >= 0)
            {
                int count = (refCount - callCount) + 1;
                for(int i = 0; i<count; i++) { doEvent += MoveAnimEvent; }
            }
            if (doEvent != null)
            {
                doEvent();
                doEvent = null;
                callCount++;
            }
        }
	}
}
