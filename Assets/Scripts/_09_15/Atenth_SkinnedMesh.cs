using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atenth_SkinnedMesh : MonoBehaviour
{
    SkinnedMeshRenderer renderer;
    void Start()
    {
        renderer = GetComponentInChildren<SkinnedMeshRenderer>();

        Vector3[] arrayVertex = renderer.sharedMesh.vertices;
        float xMin = arrayVertex[0].x;
        float xMax = arrayVertex[0].x;
        float yMin = arrayVertex[0].y;
        float yMax = arrayVertex[0].y;
        float zMin = arrayVertex[0].z;
        float zMax = arrayVertex[0].z;
        Debug.Log("정점정보출력");


        for (int i = 0; i < arrayVertex.Length; i++)
        {
            if (xMin > arrayVertex[i].x) { xMin = arrayVertex[i].x; }
            if (xMax < arrayVertex[i].x) { xMax = arrayVertex[i].x; }
            if (yMin > arrayVertex[i].y) { yMin = arrayVertex[i].y; }
            if (yMax < arrayVertex[i].y) { yMax = arrayVertex[i].y; }
            if (zMin > arrayVertex[i].z) { zMin = arrayVertex[i].z; }
            if (zMax < arrayVertex[i].z) { zMax = arrayVertex[i].z; }
        }

        

        float xsize = Mathf.Abs(xMax - xMin) * transform.localScale.x;
        float ysize = Mathf.Abs(yMax - yMin) * transform.localScale.y;
        float zsize = Mathf.Abs(zMax - zMin) * transform.localScale.z;

        Debug.Log($"x의 크기 = {xsize}");
        Debug.Log($"y의 크기 = {ysize}");
        Debug.Log($"z의 크기 = {zsize}");


        Vector3 center = new Vector3((xMax + xMin) * transform.localScale.x * 0.5f,
                                     (yMax + yMin) * transform.localScale.y * 0.5f,
                                     (zMax + zMin) * transform.localScale.z * 0.5f);

        BoxCollider bc = gameObject.AddComponent<BoxCollider>();

		bc.size = new Vector3(xsize, zsize, ysize);
		bc.center = new Vector3(center.x, center.z, center.y);


		//bc.size = renderer.bounds.size;
		//bc.center = transform.InverseTransformPoint(renderer.bounds.center);


	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
