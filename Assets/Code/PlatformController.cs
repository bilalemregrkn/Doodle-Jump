using UnityEngine;

public class PlatformController : MonoBehaviour
{
	[SerializeField] private float force;
    
	private void OnCollisionEnter2D(Collision2D col)
	{
		if (col.transform.CompareTag("Player"))
		{
			var player = col.transform.GetComponent<PlayerController>();
			player.Jump(force);
		}
	}
}