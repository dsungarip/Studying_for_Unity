using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _09_27_LoadScene : MonoBehaviour
{
	void Awake()
	{
        ResourceManager.instance.LoadrcCharacter();
		SceneManager.LoadScene("_09_27_MainScene");
	}
}
