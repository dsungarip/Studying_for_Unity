using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _09_16_ResourcesLoad : MonoBehaviour
{
    
    void Start()
    {
        // Resources.Load : 빌드시 포함된 에셋에 메모리에 불러오는 함수이다.
        // 불러오기 위해선 Resources 폴더가 있어야만 한다.
        // 파일확장자X, 폴더구분 /,\ 다가능
        // 리소스를 로드하는 두가지 방법
        GameObject obj_1 = Resources.Load("Golem") as GameObject;
        GameObject obj_2 = Resources.Load<GameObject>("Golem");

        //하위폴더가 있으면 폴더명을 명시한다, /로 구분
        GameObject obj_3 = Resources.Load<GameObject>("Character/TrollGiant");

        //여러개의 리소스를 한번에 메모리에 가져올때
        GameObject[] objs = Resources.LoadAll<GameObject>("Character");

        // 인스턴스 생성
        GameObject createobj = Instantiate(obj_3);

        // 생성된 인스턴스의 인스펙터 변경
        createobj.transform.position = new Vector3(10, 10, 10);
        createobj.name = "gimotti";
    }

    
    void Update()
    {
        
    }
}
