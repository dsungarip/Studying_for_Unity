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

 //   // RigidBody와 Collider 컴포넌트가 추가된 게임오브젝트가 충돌시작시 자동호출
	//private void OnCollisionEnter(Collision collision)
	//{
 //       Debug.Log($"충돌시작 게임오브젝트 : {collision.gameObject.name}");
	//}
	////RigidBody와 Collider 컴포넌트가 추가된 게임오브젝트가 충돌중일시 자동호출
	//private bool OnCollisionStay(Collision collision)
	//{
	//	Debug.Log($"충돌중 게임오브젝트 : {collision.gameObject.name}");
	//	return true;
	//}
	////RigidBody와 Collider 컴포넌트가 추가된 게임오브젝트가 충돌종료시 자동호출
	//private void OnCollisionExit(Collision collision)
	//{
	//	Debug.Log($"충돌종료 게임오브젝트 : {collision.gameObject.name}");
	//}
	private void OnTriggerEnter(Collider other)
	{
		Debug.Log($"트리거 충돌시작 대상: {other.name}");
	}
	private void OnTriggerStay(Collider other)
	{
		Debug.Log($"트리거 충돌중 : {other.name}");
	}
	private void OnTriggerExit(Collider other)
	{
		Debug.Log($"트리거 충돌종료 : {other.name}");
	}
	void Update()
    {
		
	}
}
