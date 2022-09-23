using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//싱글톤을 제네릭으로 선언
// T의 제약조건은 참조형식이어야하고( class )
// 매개변수가 없는 생성자여야 한다( new() )
public class _09_23_Singleton2<T> where T : class, new()
{
    private static T inst;

    public _09_23_Singleton2()
	{
		inst = null;
	}
	public static T instance
	{
		get
		{
			if(inst == null) { inst = new T(); }

			return inst;
		}
	}
}
