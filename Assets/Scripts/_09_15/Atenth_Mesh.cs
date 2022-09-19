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
        Debug.Log("�����������");

        
        

        for(int i =0; i < arrayVertex.Length; i++)
		{
            if (xMin > arrayVertex[i].x) { xMin = arrayVertex[i].x; }
            if (xMax < arrayVertex[i].x) { xMax = arrayVertex[i].x; }
            if (yMin > arrayVertex[i].y) { yMin = arrayVertex[i].y; }
            if (yMax < arrayVertex[i].y) { yMax = arrayVertex[i].y; }
            if (zMin > arrayVertex[i].z) { zMin = arrayVertex[i].z; }
            if (zMax < arrayVertex[i].z) { zMax = arrayVertex[i].z; }
        }
        Debug.Log($"x�� ũ�� = {Mathf.Abs(xMax - xMin) * transform.localScale.x}");
        Debug.Log($"y�� ũ�� = {Mathf.Abs(yMax - yMin) * transform.localScale.y}");
        Debug.Log($"z�� ũ�� = {Mathf.Abs(zMax - zMin) * transform.localScale.z}");


        BoxCollider bc = gameObject.AddComponent<BoxCollider>();


        Debug.Log("������ �ε��� ���");
        foreach (int one in meshfilter.mesh.triangles)
		{
            Debug.Log(one);
		}

        Debug.Log("UV��ǥ ���");
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
