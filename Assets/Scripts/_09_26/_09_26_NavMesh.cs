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
        //���콺 �ȿ� ���� ���콺�� ������ ���Ӱ������� ��ǥ�� ���

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

        // �׺���̼� �޽�������Ʈ�� ������
        if(Input.GetKeyDown(KeyCode.Space))
		{
            //�����̽��� ������� transform.forward��ŭ �̵�
            nav.Move(transform.forward);
		}
        
    }
}