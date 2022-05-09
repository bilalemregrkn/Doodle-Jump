using UnityEngine;

public class KillCollider : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D col)
	{
		if (col.transform.CompareTag("Player"))
		{
			GameManager.Instance.GameOver();
		}
	}
}