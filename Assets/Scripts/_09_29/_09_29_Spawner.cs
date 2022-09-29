using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 일정한 시간간격으로 캡슐을 생성해보기

public class _09_29_Spawner : MonoBehaviour
{
    public int spawnerIndex;

    float ticTime;
    float RandTime;
    void Start()
    {
        ticTime = 0;
        RandTime = Random.Range(3.0f, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        ticTime += Time.deltaTime;
        RandTime = Random.Range(3.0f, 10.0f);
        if(ticTime >= RandTime)
		{
            ticTime -= RandTime;

            GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            obj.transform.position = transform.position;
            obj.tag = "Monster";

            _09_29_Monster script = obj.AddComponent<_09_29_Monster>();

            script.End = new Vector3(transform.position.x, transform.position.y, 4.5f);
            script.spawnerIndex = spawnerIndex;
            script.moveSpeed = 2.5f;

		}

    }
}
