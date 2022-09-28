using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _09_28_Practice_Singleton<T> where T : class, new()
{
    private static T s_instance;
	public _09_28_Practice_Singleton()
	{
		s_instance = null;
	}
	public static T Instance()
	{
		if(s_instance == null) { s_instance = new T(); }
		return s_instance;
		Stack stack = new Stack();

	}
}
