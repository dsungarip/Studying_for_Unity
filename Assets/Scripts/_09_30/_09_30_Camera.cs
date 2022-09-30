using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _09_30_Camera : MonoBehaviour
{
    public _09_30_Character1 Player;
    Vector3 camPos = new Vector3(0f, 10f, -10f);
    Vector3 playerPos;
    void Start()
    {
        playerPos = Player.transform.position;

        transform.position = playerPos - new Vector3(0f, 10f, -10f);
        transform.rotation = Quaternion.Euler(45f, 0, 0);
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Player.transform.position + camPos;
    }
}
