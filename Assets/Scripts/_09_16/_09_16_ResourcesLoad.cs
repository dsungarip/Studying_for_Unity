using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _09_16_ResourcesLoad : MonoBehaviour
{
    
    void Start()
    {
        // Resources.Load : ����� ���Ե� ���¿� �޸𸮿� �ҷ����� �Լ��̴�.
        // �ҷ����� ���ؼ� Resources ������ �־�߸� �Ѵ�.
        // ����Ȯ����X, �������� /,\ �ٰ���
        // ���ҽ��� �ε��ϴ� �ΰ��� ���
        GameObject obj_1 = Resources.Load("Golem") as GameObject;
        GameObject obj_2 = Resources.Load<GameObject>("Golem");

        //���������� ������ �������� ����Ѵ�, /�� ����
        GameObject obj_3 = Resources.Load<GameObject>("Character/TrollGiant");

        //�������� ���ҽ��� �ѹ��� �޸𸮿� �����ö�
        GameObject[] objs = Resources.LoadAll<GameObject>("Character");

        // �ν��Ͻ� ����
        GameObject createobj = Instantiate(obj_3);

        // ������ �ν��Ͻ��� �ν����� ����
        createobj.transform.position = new Vector3(10, 10, 10);
        createobj.name = "gimotti";
    }

    
    void Update()
    {
        
    }
}
