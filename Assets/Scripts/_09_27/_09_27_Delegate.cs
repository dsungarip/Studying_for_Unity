using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// return type void & No parameter

// 1.Update 함수에서 조건문을 한번만 사용하여 특정 이벤트에만 함수 호출을 할수 있는 코드작성(제한: 함수호출은 1번만)
//





public delegate void Do(); 

public class _09_27_Delegate : MonoBehaviour
{
    Do doFunc;
    Do doAnother;

    // Action<매개변수 자료형> : return이 없다
    Action<float> action;


    // Func<매개변수 자료형, 리턴타입>
    Func<int, bool> func;


    public Do doAdd { get { return doAnother; } set { doAnother += value; } }
    public Do doSet { get { return doAnother; } set { doAnother += value; } }
    void Start()
    {
        doFunc = null;
        doAnother = null;
        doAdd = Test;
        doAdd = Test;
        doAnother();

        doAnother -= Test;
        Debug.Log("doAnother -= test 호출후");

        doAnother();

        action = Test3;

        func = Test4;
    }

    public bool Test4(int value)
	{
        Debug.Log("Test4");

        return (value > 2) ? true : false;
	}

    public void Test3(float value)
	{
        Debug.Log(value);
	}

    public void Test()
	{
        Debug.Log("Test");
	}
    public void Test2()
    {
        Debug.Log("Test2");
    }
    //   public void SetFunction(Do _do)
    //{
    //       doAnother = _do;
    //}
    //   public void SetAddFunction(Do _do)
    //{
    //       doAnother += _do;
    //}
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F1))
		{
            doFunc += Test;
            doFunc += Test2;
            //doAnother();


            //GetInvocationList : 대리자의 호출목록을 반환해준다.
            Delegate[] arrFunc = doFunc.GetInvocationList();

            ((Do)arrFunc[0])();
            ((Do)arrFunc[1])();
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            action(3.0f);
            func(1000);
		}

        if (doFunc != null)
		{
            doFunc();
            doFunc = null;
		}
    }
}
