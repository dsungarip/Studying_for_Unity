using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _09_15_Physics : MonoBehaviour
{
	Collision collision;
	// Start is called before the first frame update
	void Start()
    {
		

	}

 //   // RigidBody�� Collider ������Ʈ�� �߰��� ���ӿ�����Ʈ�� �浹���۽� �ڵ�ȣ��
	//private void OnCollisionEnter(Collision collision)
	//{
 //       Debug.Log($"�浹���� ���ӿ�����Ʈ : {collision.gameObject.name}");
	//}
	////RigidBody�� Collider ������Ʈ�� �߰��� ���ӿ�����Ʈ�� �浹���Ͻ� �ڵ�ȣ��
	//private bool OnCollisionStay(Collision collision)
	//{
	//	Debug.Log($"�浹�� ���ӿ�����Ʈ : {collision.gameObject.name}");
	//	return true;
	//}
	////RigidBody�� Collider ������Ʈ�� �߰��� ���ӿ�����Ʈ�� �浹����� �ڵ�ȣ��
	//private void OnCollisionExit(Collision collision)
	//{
	//	Debug.Log($"�浹���� ���ӿ�����Ʈ : {collision.gameObject.name}");
	//}
	private void OnTriggerEnter(Collider other)
	{
		Debug.Log($"Ʈ���� �浹���� ���: {other.name}");
	}
	private void OnTriggerStay(Collider other)
	{
		Debug.Log($"Ʈ���� �浹�� : {other.name}");
	}
	private void OnTriggerExit(Collider other)
	{
		Debug.Log($"Ʈ���� �浹���� : {other.name}");
	}
	void Update()
    {
		
	}
}
