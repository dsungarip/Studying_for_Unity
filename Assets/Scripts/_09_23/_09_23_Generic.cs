using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MonsterTest<T>
{
    public T data { get; set; }
    public MonsterTest() 
    { 
        Debug.Log("MonsterTest »ý¼ºÀÚ");
    }
    public void DisplayData()
	{
        Debug.Log(data);
	}
}
public class _09_23_Generic : MonoBehaviour
{
    MonsterTest<int> nick;
    MonsterTest<float> lee;
    MonsterTest<DateTime> dateTime;
    void Start()
    {
        nick = new MonsterTest<int>();
        lee = new MonsterTest<float>();
        dateTime = new MonsterTest<DateTime>();

        nick.data = 100;
        nick.DisplayData();
        lee.data = 300.22f;
        lee.DisplayData();
        dateTime.data = DateTime.Now;
        dateTime.DisplayData();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
