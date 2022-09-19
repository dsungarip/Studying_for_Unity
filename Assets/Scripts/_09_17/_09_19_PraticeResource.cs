using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _09_19_PraticeResource : MonoBehaviour
{
	// 문제1
	// 게임실행중, 스페이스바를 누르면 TrollGiant라는 프리팹을 로드후 인스턴스를 생성
	// 생성시 생성좌표는 x: -8 ~ +8, y: -3 ~ +3, z: 0~ 10범위에서 무작위로 생성

	// 문제2
	// 실행시 TrollGiant를 1초마다 한번씩 화면에 생성해 주는 프로그램 코드를 작성하시오

	// 문제3
	// 실행시 20개의 TrollGiant의 인스턴스를 화면에 생성하되 생성한 게임오브젝트는 연결리스트에 저장한다.
	// 화면상에서 마우스로 선택한 게임오브젝트를 비활성화 시키시오, 마우스 픽에의한 검사를 사용한다.
	// 마우스로 선택한 게임오브젝트를 리스트에서 검색하여 비활성화 하시오

	// 문제5
	// 실행시 TrollGiant 20개 생성하고 화면에서 선택한 게임오브젝트의 태그를 Monster인지를 비교하는
	// 프로그램 코드를 작성하시오, (Monster 태그는 등록되어 있어야한다.)

	// 문제6
	// 높이차이가 있는바닥에 여러마리의 몬스터를 배치하고자 한다. 이에 대한 방법은?
	// A) 하늘에서부터 바닥을 향해 Raycast를 한다.



	List<GameObject> list;
	GameObject obj;
	float time;

	GameObject Monster;
	Transform MonsterParent;

	void Start()
    {
		time = 0f;
		Monster = new GameObject("Monster");
		MonsterParent = Monster.GetComponent<Transform>();
		obj = Resources.Load<GameObject>("Character/TrollGiant");
		list = new List<GameObject>();

		StartMonsterSpawn();
	}



	void Update()
    {
		//time += Time.deltaTime;

		//if (Input.GetKeyDown(KeyCode.Space)) { CreateTroll(); }

		//if (time >= 1)
		//{
		//	CreateTroll();
		//	time -= 1;
		//}

		//OnMouseClick();

		//OnMouseClick2();

		OnMouseClick3();
	}

	void CreateTroll()
	{
		if (obj != null)
		{
			GameObject trollGiant = Instantiate(obj);
			trollGiant.transform.position = new Vector3(Random.Range(-8, 8), Random.Range(-3, 3), Random.Range(0, 10));
		}
		else { Debug.LogError("ERROR! Invalid assets in folder!"); }
	}

	void OnMouseClick()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit, Mathf.Infinity))
			{
				Debug.DrawRay(ray.origin, ray.direction * 40, Color.red, 2.0f);
				hit.collider.gameObject.SetActive(false);
			}
		}
	}


	void OnMouseClick2()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit, Mathf.Infinity))
			{
				Debug.DrawRay(ray.origin, ray.direction * 40, Color.red, 2.0f);
				SearchList(hit.collider.name);
			}
		}
	}

	void OnMouseClick3()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit, Mathf.Infinity))
			{
				Debug.DrawRay(ray.origin, ray.direction * 40, Color.red, 2.0f);

				// string 문자열의 비교를 진행할때 유니티는 문자열의 복사본을 생성한다.(문자열은 참조형식이다.)
				// 복사본이 계속해서 생성되면 힙메모리 할당이 계속 이루어지고 이는 곧 가비지로 이어진다.
				// 최적화 측면에서 태그의 비교는 CompareTag를 사용하는것이 합리적이다.
				if(hit.collider.CompareTag("Monster"))
				{
					Debug.Log("몬스터당");
				}
			}
		}
	}

	void StartMonsterSpawn()
	{
		for (int i = 0; i<20; i++)
		{
			GameObject trollGiant = Instantiate(obj);
			trollGiant.transform.position = new Vector3(Random.Range(-8, 8), Random.Range(-3, 3), Random.Range(0, 10));
			trollGiant.name = $"TrollGiant{i}";
			trollGiant.transform.SetParent(MonsterParent);
			list.Add(trollGiant);
		}
	}

	void SearchList(string name)
	{
		foreach(GameObject obj in list)
		{
			//문자열 비교할때는 == 관계연산자보다 Equals 함수를 사용하는게 이득이다(왜?)
			if(obj.name.Equals(name)) 
			{
				Debug.Log($"{name} is Active false!");
				//obj.SetActive(false);
				Destroy(obj);
				list.Remove(obj);
				break; 
			}
		}

		// 반복문 안쓰는 방법
		GameObject findObject = list.Find(o => o.name.Equals(name));
		if(findObject != null)
		{
			findObject.SetActive(false);
		}
	}
}
