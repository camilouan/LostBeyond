using UnityEngine;

public class Enemigo : MonoBehaviour
{
	private void OnCollisionEnter2D(Collision2D other)
	{
        if (other.gameObject.CompareTag("Player")) GameManager.Instance.PerderVidas();
	}
}
