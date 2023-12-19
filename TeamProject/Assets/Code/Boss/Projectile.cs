using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializableAttribute]
public class Projectile : MonoBehaviour
{
	public Vector3 direction;
	public float speed;

	void Update()
	{
		transform.Translate(direction.normalized * speed * Time.deltaTime);
	}

}
