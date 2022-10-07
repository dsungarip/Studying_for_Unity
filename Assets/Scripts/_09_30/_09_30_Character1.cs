using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _09_30_Character1 : MonoBehaviour
{
    Vector3 end;
    public float speed = 5.0f;
    public float rSpeed = 5.0f;
    void Awake()
    {
        gameObject.transform.position = new Vector3(0f, 0.5f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
		{
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
			{
                if(hit.collider == null)
				{
                    Debug.Log("이동불가");
                }
                else if(hit.collider.gameObject == gameObject)
				{
                    Debug.Log(gameObject.name);
				}
				else
				{
                    MoveCharacter(hit.point);
                    RotateCharacter(hit.point);
                }
			}
		}
    }

    void MoveCharacter(Vector3 end)
	{
        Vector3 movepos = Vector3.MoveTowards(transform.position, end, Time.deltaTime * speed);
        movepos.y = transform.position.y;
        transform.position = movepos;
    }
    void RotateCharacter(Vector3 end)
	{
        Vector3 tmpEnd = end;
        tmpEnd.y = transform.position.y;

        Vector3 dir = tmpEnd - transform.position;
        Vector3 newDir = Vector3.RotateTowards(transform.forward, dir.normalized, Time.deltaTime * rSpeed, 0);
        transform.rotation = Quaternion.LookRotation(newDir.normalized);
    }
}
