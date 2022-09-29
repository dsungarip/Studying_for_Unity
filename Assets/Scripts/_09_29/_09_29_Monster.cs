using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _09_29_Monster : MonoBehaviour
{
    public Vector3 End { get; set; }
    public int spawnerIndex { get; set; }
    public float moveSpeed { get; set; }

    void Start()
    {
        
    }

    
    void Update()
    {

        gameObject.transform.position = Vector3.MoveTowards(transform.position, End, Time.deltaTime * moveSpeed);


        if (transform.position.z <= 4.5)
		{
            Destroy(gameObject);
		}
    }
}
