using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _09_23_GameManager : MonoBehaviour
{
    // ĳ���� ������Ʈ�� �� Ŭ�������� �˰� ��������
    // ���ݱ��� ����� ���
    // �׷��� Ŭ������ �̱��� �����̶�� �Ʒ��� ���� ������ �ʿ����.
    //public _09_23_Singleton player;
    void Start()
    {
        //�̱����� ������� �ʾ��� ����� Ŭ���� ��� �Լ� ȣ��
        //player.Test();

        //�̱����� ����Ǿ��� ��� Ŭ���� ��� �Լ� ȣ��
        //���������� �ʿ����! �����!
        _09_23_Singleton.instance.Test();

        ResourceManager.instance.LoadrcCharacter();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
