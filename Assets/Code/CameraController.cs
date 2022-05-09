using System;
using UnityEngine;


public class CameraController : MonoBehaviour
{
	[SerializeField] private Transform target;

	private void FixedUpdate()
	{
		if (transform.position.y < target.position.y)
		{
			var position = transform.position;
			position.y = Mathf.Lerp(position.y, target.position.y, 0.5f);
			transform.position = position;
		}
	}
}