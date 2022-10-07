using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _09_30_Camera : MonoBehaviour
{
    public _09_30_Manager Player;
    public GameObject obj;
    Vector3 playerOldPos;

    void Start()
    {
        playerOldPos = Player.cam.transform.position;
        obj = Player.GetComponent<GameObject>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 delta = Player.transform.position - playerOldPos;
        transform.position += delta;
        playerOldPos = Player.transform.position;
    }
}
