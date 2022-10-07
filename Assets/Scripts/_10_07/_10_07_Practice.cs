using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _10_07_Practice : MonoBehaviour
{
    float time;
    void Start()
    {
        time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if(time > 3.0f)
		{
            //실행구문

            time -= 3.0f;
		}
    }
}

