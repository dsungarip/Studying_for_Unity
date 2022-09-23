using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�̱����� ���׸����� ����
// T�� ���������� ���������̾���ϰ�( class )
// �Ű������� ���� �����ڿ��� �Ѵ�( new() )
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
