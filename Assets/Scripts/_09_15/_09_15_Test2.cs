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
		Debug.Log("�浹���� �浹��");
		Invoke("ObjTrue", 3f);
	}

	void Update()
    {
		Debug.Log("������Ʈ ���� �׽�Ʈ");
	}

	private void ObjTrue()
	{
		gameObject.SetActive(true);
	}
}
