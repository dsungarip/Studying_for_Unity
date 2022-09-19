using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 씬에 올려진 게임오브젝트 10개에 Character라는 컴포넌트가 추가되어 있다고 가정
 게임오브젝트를 관리할 연결리스트를 선언해보자
 */
public class Atenth_Quad : MonoBehaviour
{
    List<_09_15_PracticeCharacter> characterList;
    List<GameObject> objList = new List<GameObject>();

    public GameObject obj1;
    public _09_15_PracticeCharacter obj2;


    void Start()
    {
        Debug.Log(characterList[0].gameObject);
        _09_15_PracticeCharacter scriptCharacter = objList[0].GetComponent<_09_15_PracticeCharacter>();

        _09_15_PracticeCharacter script = obj1.GetComponent<_09_15_PracticeCharacter>();

        Debug.Log(obj2.gameObject);

        Createbillboard(2f, 4f);
    }

    public GameObject Createbillboard(float width, float height)
	{
        GameObject obj = new GameObject("BillBoard");
        MeshFilter mf = new MeshFilter();
        Mesh mesh = new Mesh();

        Vector3[] vertices = new Vector3[4] {new Vector3(-width / 2, 0, 0), new Vector3(width / 2, 0, 0),
                                            new Vector3(-width / 2, height, 0), new Vector3(width / 2, height, 0)};
        mesh.vertices = vertices;


        int[] triangles = new int[6] {0, 2, 1,
                                     2, 3, 1,};
        mesh.triangles = triangles;

        Vector3[] normals = new Vector3[4] { Vector3.forward, Vector3.forward, Vector3.forward, Vector3.forward };
        mesh.normals = normals;

        Vector2[] uv = new Vector2[4] { new Vector2(0, 0), new Vector2(1, 0), new Vector2(0, 1), new Vector2(1, 1) };
        mesh.uv = uv;

        obj.AddComponent<MeshFilter>().mesh = mesh;
        obj.AddComponent<MeshRenderer>();

        return obj;
	}
    // Update is called once per frame
    void Update()
    {

    }
}
