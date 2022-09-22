using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���콺 �ȿ� ���� �ִϸ��̼��� ������ ĳ���� �̵�
// ����(ĸ��)�� ���ӿ�����Ʈ���� ��ġ�ϰ� ���͸� �������� ���, ���Ϳ��� �ٰ�����
// �����ϴ� �ڵ带 �ۼ��Ͻÿ�
public class _09_21_MechanimAnimation : MonoBehaviour
{
    public Animator ani;
    float speed = 5f;
    float rSpeed = 10f;
    public Vector3 end { get; set; }
    int state;
    RaycastHit hitInfo;
    Ray ray;
    public Transform target { get; set; }
    public float attackRange { get; set; }
    Vector3 t_Pos;

    void Start()
    {
        target = null;
        attackRange = 2f;
    }

    public void PlayerMove()
	{
        Vector3 movepos = Vector3.MoveTowards(transform.position, end, Time.deltaTime * speed);
		movepos.y = transform.position.y;
        transform.position = movepos;
    }
    public void PlayerRotate()
	{
        Vector3 tmpEnd = end;
        tmpEnd.y = transform.position.y;

        Vector3 dir = tmpEnd - transform.position;
        Vector3 newDir = Vector3.RotateTowards(transform.forward, dir.normalized, Time.deltaTime * rSpeed, 0);
        transform.rotation = Quaternion.LookRotation(newDir.normalized);
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
            {
                
                if(hitInfo.collider.CompareTag("Monster"))
				{
                    end = hitInfo.collider.transform.position;
                    target = hitInfo.collider.transform;
                }
				else if(hitInfo.collider.CompareTag("Plane"))
                {
                    end = hitInfo.point;
                    target = null;
                }
                else if(hitInfo.collider.CompareTag("Player")) 
                { 
                    target = null;
                    end = hitInfo.point;
                }
            }
        }
  //      if(target != null)
		//{
  //          float distance = Vector3.Distance(target.position, transform.position);
  //          if (distance <= 2)
		//	{
  //              end = transform.position;

  //              Vector3 dire = target.position - transform.position;
  //              Quaternion quat = Quaternion.LookRotation(dire);
  //              transform.rotation = Quaternion.Lerp(transform.rotation, quat, 10 * Time.deltaTime);

  //              ani.SetInteger("aniIndex", 2);
  //          }
		//	else
		//	{
  //              ani.SetInteger("aniIndex", 1);
  //          }
  //      }
  //      else
		//{
  //          if (end == transform.position) { ani.SetInteger("aniIndex", 0); }
  //          else { ani.SetInteger("aniIndex", 1); }
  //      }
  //      end.y = transform.position.y;
        


    }

    void InputMouse()
	{
        
    }

}
