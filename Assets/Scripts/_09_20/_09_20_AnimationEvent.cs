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
  //      Debug.Log($"애니메이션 클립의 개수는 총 {clipInfos.Length} 개");
        
  //      foreach(AnimatorClipInfo one in clipInfos)
		//{
  //          Debug.Log($"{one.clip.name}의 길이는 {one.clip.length} 초 입니다.");
		//}

    }

    public void MoveAnimEvent()
	{
        Debug.Log("MoveAnimEvent 함수 호출");
	}
    
    void Update()
    {
        // GetCurrentAnimatorStateInfo(0).IsName("Move") : anim의 상태가 Move인지 bool반환
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Move"))
        {
            // GetCurrentAnimatorStateInfo(0).normalizedTime : 애니메이션의 시간을 0~1로 보간
            duration = anim.GetCurrentAnimatorStateInfo(0).normalizedTime % 1f;

            //refCount : 애니메이션의 재생횟수를 가진다.
            refCount = (int)anim.GetCurrentAnimatorStateInfo(0).normalizedTime;


            //애니메이션 진행시간이 80% 이상 && 두 Count값이 같다면
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
