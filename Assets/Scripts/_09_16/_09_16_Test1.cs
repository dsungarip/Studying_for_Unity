using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _09_16_Test1 : MonoBehaviour
{
    float speed = 100.0f;
    Rigidbody rb;
    Vector3 dir;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
	//private void OnTriggerEnter(Collider other)
	//{
        
	//	if(other.name.Equals("Item"))
	//	{
 //           Debug.Log($"{other.name} �̵��ٳ����� ��í�ƾ�!");
 //           other.gameObject.SetActive(false);
	//	}
	//}

	private void OnCollisionEnter(Collision collision)
	{
		if(collision.rigidbody.name.Equals("Item"))
		{
			Debug.Log($"{collision.rigidbody.name} �̵��ٳ����� ��í�ƾ�!");
			collision.gameObject.SetActive(false);
		}
	}
	private void FixedUpdate()
	{
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        dir.Set(x, 0, y);
        rb.velocity = dir.normalized * speed * Time.fixedDeltaTime;
	}
	void Update()
    {
  //      if(Input.anyKey)
		//{
  //          OnKeyboardPress();
  //      }
    }

 //   void OnKeyboardPress()
	//{
 //       Debug.Log("Ű���� ������");
 //       if(Input.GetKey(KeyCode.W))
	//	{
 //           rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 0f);
	//	}
 //       if(Input.GetKey(KeyCode.S))
	//	{
 //           gameObject.transform.position += Vector3.back * Time.deltaTime * speed;
	//	}
 //       if(Input.GetKey(KeyCode.D))
	//	{
 //           gameObject.transform.position += Vector3.right * Time.deltaTime * speed;
 //       }
 //       if (Input.GetKey(KeyCode.A))
 //       {
 //           gameObject.transform.position += Vector3.left * Time.deltaTime * speed;
 //       }
 //   }
}
