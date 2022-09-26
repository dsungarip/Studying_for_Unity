using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class _09_26_NavMesh : MonoBehaviour
{
    public NavMeshAgent nav;
    public Animator ani;
    public Vector3 end { get; set; }
    public bool b;
    float yVelocity;
    float smoothTime;
    Vector3 towarBack;
    float elapsed;

    void Start()
    {
        nav.destination = transform.position;
    }

    public void MovePlayer(Vector3 point)
	{
        nav.destination = point;
        ani.SetInteger("aniIndex", 1);
    }
    void Update()
    {
        //마우스 픽에 의한 마우스로 선택한 게임공간상의 좌표를 출력

        if(Input.GetMouseButton(0))
		{
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if(Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
			{
                Debug.Log(hitInfo.point);
                end = hitInfo.point;
                MovePlayer(end);
            }
        }
        if (nav.destination == transform.position)
        {
            ani.SetInteger("aniIndex", 0);
        }
		else
		{
            ani.SetInteger("aniIndex", 1);
        }

        // 네비게이션 메쉬에이전트의 오프셋
        if(Input.GetKeyDown(KeyCode.Space))
		{
            //스페이스를 누를경우 transform.forward만큼 이동
            nav.Move(transform.forward);
		}
        
    }
}