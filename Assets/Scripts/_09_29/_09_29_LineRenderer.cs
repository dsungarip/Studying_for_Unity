using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 라인렌더러의 targetPos위치에 sphere를 생성하시오
// 라인랜더의 선과 맞닿는 부분의 게임오브젝트는 파괴
public class _09_29_LineRenderer : MonoBehaviour
{
    public LineRenderer lineRenderer;
    Vector3 targetPos;
    Vector3 end;
    float lineSpeed;
    float moveSpeed;
    GameObject createdObj;
    void Start()
    {
        lineRenderer.SetPosition(0, transform.position);

        end = transform.position;
        lineSpeed = 20.0f;
        moveSpeed = 20.0f;

    }

    void FindInterSectPosition()
	{
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity))
		{
            targetPos = hit.point;
            lineRenderer.SetPosition(0, transform.position);

            //if (end == targetPos && hit.collider.CompareTag("Board"))
            //{
            //    CreateSphere();
            //}
            if(end == targetPos && hit.collider.CompareTag("Monster"))
			{
                Destroy(hit.transform.gameObject);
			}
        }
	}

    void CreateSphere()
	{
        if (createdObj == null)
		{
            GameObject createdObj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            createdObj.transform.position = targetPos;
            createdObj.tag = "Sphere";  //생성한 게임오브젝트에 태그를 추가
            //createdObj.tag = "HappyDay";    //유니티 태그목록에 없다면, 오류발생
        }
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
		{
            transform.position += Vector3.right * moveSpeed * Time.deltaTime; 
		}
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }



        if (Input.GetKey(KeyCode.Space))
		{
            FindInterSectPosition();
            end = Vector3.MoveTowards(end, targetPos, Time.deltaTime * lineSpeed);
            lineRenderer.SetPosition(1, end);
        }
        else
		{
            end = transform.position;

            lineRenderer.SetPosition(0, transform.position);
            lineRenderer.SetPosition(1, transform.position);
        }

    }
}
