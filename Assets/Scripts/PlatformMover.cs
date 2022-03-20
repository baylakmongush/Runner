using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
	public float speed = 0.02f;
	private void Update()
	{
		transform.position += Vector3.left * speed * Time.deltaTime;
		if (transform.position.x < -10)
				Destroy(gameObject);
	}
}
