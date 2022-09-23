using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _09_23_Singleton : MonoBehaviour
{

    public static _09_23_Singleton instance;

    public void Test()
	{
        Debug.Log("_09_23_Singleton의 Test함수호출");
	}
	public void Awake()
	{
        instance = this;
    }

	void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
