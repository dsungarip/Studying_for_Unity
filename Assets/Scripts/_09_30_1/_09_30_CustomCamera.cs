using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _09_30_CustomCamera : MonoBehaviour
{
    public _09_30_Player Player;
    Vector3 playerOldPos;
    
    void Start()
    {
        playerOldPos = Player.transform.position;

        transform.position = playerOldPos - new Vector3(0f, 10f, -10f);
        transform.rotation = Quaternion.Euler(45f, 0, 0);
    }

    
    void Update()
    {
        
    }

	void LateUpdate()
	{
		Vector3 delta = Player.transform.position - playerOldPos;
        transform.position += delta;
        playerOldPos = Player.transform.position;
    }
}
