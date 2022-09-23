using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _09_23_GameManager : MonoBehaviour
{
    // 캐릭터 컴포넌트를 이 클래스에서 알고 있으려면
    // 지금까지 사용한 방식
    // 그런데 클래스가 싱글톤 패턴이라면 아래와 같은 선언이 필요없다.
    //public _09_23_Singleton player;
    void Start()
    {
        //싱글톤이 적용되지 않았을 경우의 클래스 멤버 함수 호출
        //player.Test();

        //싱글톤이 적용되었을 경우 클래스 멤버 함수 호출
        //변수선언이 필요없다! 놀랍다!
        _09_23_Singleton.instance.Test();

        ResourceManager.instance.LoadrcCharacter();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
