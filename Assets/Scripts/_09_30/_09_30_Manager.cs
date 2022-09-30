using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _09_30_Manager : MonoBehaviour
{
	public GameObject obj;
	public GameObject cam;

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
			GameObject character = Resources.Load<GameObject>("Character/TrollGiant");
			obj = Instantiate(character);
			obj.AddComponent<_09_30_Character1>();
		}
		
	}
	public void LoadCamera()
	{
		cam = GameObject.Find("Main Camera");
		if (cam == null)
		{
			cam = new GameObject();
			cam.AddComponent<Camera>();
			cam.AddComponent<_09_30_Camera>();
		}
		cam.TryGetComponent
	}
}

