using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _09_30_Character : MonoBehaviour
{
    public float xRotate, yRotate, xRotateMove, yRotateMove;
    public float rotateSpeed = 500.0f;
    void Start()
    {
        Debug.Log(Camera.main.transform.eulerAngles);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) // 클릭한 경우
        {
            xRotateMove = -Input.GetAxis("Mouse Y") * Time.deltaTime * rotateSpeed;
            yRotateMove = Input.GetAxis("Mouse X") * Time.deltaTime * rotateSpeed;

            //yRotate = transform.eulerAngles.y + yRotateMove;
            //xRotate = transform.eulerAngles.x + xRotateMove; 
            yRotate = yRotate + yRotateMove;
            xRotate = xRotate + xRotateMove;

            xRotate = Mathf.Clamp(xRotate, -90, 90); // 위, 아래 고정

            transform.eulerAngles = new Vector3(xRotate, yRotate, 0);
        }
    }

    void Move()

    {
        float x = Input.GetAxis("Horizontal");
       

        float y = Input.GetAxis("Vertical");

        Vector3 tmp = transform.position;

        tmp.y = tmp.y + x *3f;

        tmp.x = tmp.x + y *3f;

        transform.position = tmp;

        // 거리구하기

        float fDis = Vector3.Distance(new Vector3(10, 0, 0),transform.position);

        if (fDis < 1.0f)

        {

            Debug.Log("특정좌표 도착");

        }

    }
}
