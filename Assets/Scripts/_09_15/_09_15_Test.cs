using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _09_15_Test : MonoBehaviour
{
    float second;
    float MaxDistence = 100f;
    
    void Start()
    {
        second = 0;
    }

    // Update is called once per frame
    void Update()
    {
        second += Time.deltaTime;
        if(second > 1)
		{
            CreatedGameObject();
            second -= 1f;
		}
        MouseInput();
    }

    void CreatedGameObject()
	{
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(Random.Range(-4f, 4f), Random.Range(-2f, 4f), Random.Range(-4f, 4f));
    }

    void MouseInput()
	{
        if(Input.GetMouseButtonDown(0))
		{
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
			{
                Debug.DrawRay(ray.origin, ray.direction * 10,Color.red, 2f);
                Debug.Log($"Hit! {hit.transform.gameObject.name}");
                Destroy(hit.transform.gameObject);
			}
        }
        
	}
}
