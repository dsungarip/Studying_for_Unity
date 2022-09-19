using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atenth_Mesh : MonoBehaviour
{
    MeshFilter meshfilter;
    void Start()
    {
        meshfilter = GetComponent<MeshFilter>();
        Vector3[] arrayVertex = meshfilter.mesh.vertices;
        float xMin = arrayVertex[0].x;
        float xMax = arrayVertex[0].x;
        float yMin = arrayVertex[0].y;
        float yMax = arrayVertex[0].y;
        float zMin = arrayVertex[0].z;
        float zMax = arrayVertex[0].z;
        Debug.Log("정점정보출력");

        
        

        for(int i =0; i < arrayVertex.Length; i++)
		{
            if (xMin > arrayVertex[i].x) { xMin = arrayVertex[i].x; }
            if (xMax < arrayVertex[i].x) { xMax = arrayVertex[i].x; }
            if (yMin > arrayVertex[i].y) { yMin = arrayVertex[i].y; }
            if (yMax < arrayVertex[i].y) { yMax = arrayVertex[i].y; }
            if (zMin > arrayVertex[i].z) { zMin = arrayVertex[i].z; }
            if (zMax < arrayVertex[i].z) { zMax = arrayVertex[i].z; }
        }
        Debug.Log($"x의 크기 = {Mathf.Abs(xMax - xMin) * transform.localScale.x}");
        Debug.Log($"y의 크기 = {Mathf.Abs(yMax - yMin) * transform.localScale.y}");
        Debug.Log($"z의 크기 = {Mathf.Abs(zMax - zMin) * transform.localScale.z}");


        BoxCollider bc = gameObject.AddComponent<BoxCollider>();


        Debug.Log("폴리곤 인덱스 출력");
        foreach (int one in meshfilter.mesh.triangles)
		{
            Debug.Log(one);
		}

        Debug.Log("UV좌표 출력");
        foreach(Vector2 one in meshfilter.mesh.uv)
		{
            Debug.Log(one);
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
