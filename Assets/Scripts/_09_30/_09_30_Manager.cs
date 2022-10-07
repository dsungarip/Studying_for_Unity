using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _09_30_Manager : MonoBehaviour
{
	public GameObject obj;
	public GameObject cam;
	Vector3 camPos =  new Vector3(0f, 10f, -10f);
	private void Start()
	{
		LoadrcCharacter();
		LoadCamera();
	}
	
	public void LoadrcCharacter()
	{
		obj = GameObject.Find("TrollGiant");
		if (obj == null)
		{
			obj = Resources.Load<GameObject>("Character/TrollGiant");
			obj = Instantiate(obj, Vector3.zero, Quaternion.identity);
			obj.AddComponent<_09_30_Character1>();
			obj.name = "TrollGiant";
		}
	}
	public void LoadCamera()
	{
		cam = GameObject.Find("Main Camera");
		if (cam == null)
		{
			cam = new GameObject("Main Camera");
			cam.AddComponent<Camera>();
			cam.AddComponent<_09_30_Camera>();
			
		}

		cam.transform.position = obj.transform.position + camPos;
		cam.transform.rotation = Quaternion.Euler(45f, 0, 0);
	}
}

