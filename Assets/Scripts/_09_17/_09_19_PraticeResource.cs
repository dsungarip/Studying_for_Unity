using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _09_19_PraticeResource : MonoBehaviour
{
	// ����1
	// ���ӽ�����, �����̽��ٸ� ������ TrollGiant��� �������� �ε��� �ν��Ͻ��� ����
	// ������ ������ǥ�� x: -8 ~ +8, y: -3 ~ +3, z: 0~ 10�������� �������� ����

	// ����2
	// ����� TrollGiant�� 1�ʸ��� �ѹ��� ȭ�鿡 ������ �ִ� ���α׷� �ڵ带 �ۼ��Ͻÿ�

	// ����3
	// ����� 20���� TrollGiant�� �ν��Ͻ��� ȭ�鿡 �����ϵ� ������ ���ӿ�����Ʈ�� ���Ḯ��Ʈ�� �����Ѵ�.
	// ȭ��󿡼� ���콺�� ������ ���ӿ�����Ʈ�� ��Ȱ��ȭ ��Ű�ÿ�, ���콺 �ȿ����� �˻縦 ����Ѵ�.
	// ���콺�� ������ ���ӿ�����Ʈ�� ����Ʈ���� �˻��Ͽ� ��Ȱ��ȭ �Ͻÿ�

	// ����5
	// ����� TrollGiant 20�� �����ϰ� ȭ�鿡�� ������ ���ӿ�����Ʈ�� �±׸� Monster������ ���ϴ�
	// ���α׷� �ڵ带 �ۼ��Ͻÿ�, (Monster �±״� ��ϵǾ� �־���Ѵ�.)

	// ����6
	// �������̰� �ִ¹ٴڿ� ���������� ���͸� ��ġ�ϰ��� �Ѵ�. �̿� ���� �����?
	// A) �ϴÿ������� �ٴ��� ���� Raycast�� �Ѵ�.



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

				// string ���ڿ��� �񱳸� �����Ҷ� ����Ƽ�� ���ڿ��� ���纻�� �����Ѵ�.(���ڿ��� ���������̴�.)
				// ���纻�� ����ؼ� �����Ǹ� ���޸� �Ҵ��� ��� �̷������ �̴� �� �������� �̾�����.
				// ����ȭ ���鿡�� �±��� �񱳴� CompareTag�� ����ϴ°��� �ո����̴�.
				if(hit.collider.CompareTag("Monster"))
				{
					Debug.Log("���ʹ�");
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
			//���ڿ� ���Ҷ��� == ���迬���ں��� Equals �Լ��� ����ϴ°� �̵��̴�(��?)
			if(obj.name.Equals(name)) 
			{
				Debug.Log($"{name} is Active false!");
				//obj.SetActive(false);
				Destroy(obj);
				list.Remove(obj);
				break; 
			}
		}

		// �ݺ��� �Ⱦ��� ���
		GameObject findObject = list.Find(o => o.name.Equals(name));
		if(findObject != null)
		{
			findObject.SetActive(false);
		}
	}
}
