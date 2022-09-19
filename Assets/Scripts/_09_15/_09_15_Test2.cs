using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _09_15_Test2 : MonoBehaviour
{
	
    void Start()
    {
		
    }

	private void OnCollisionEnter(Collision collision)
	{
		gameObject.SetActive(false);
		Debug.Log("충돌따리 충돌따");
		Invoke("ObjTrue", 3f);
	}

	void Update()
    {
		Debug.Log("업데이트 먹통 테스트");
	}

	private void ObjTrue()
	{
		gameObject.SetActive(true);
	}
}
