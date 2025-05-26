using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activarletrero : MonoBehaviour
{
	[SerializeField] private GameObject mensaje;
	private SpriteRenderer spr;

	private void Start()
	{
		spr = mensaje.GetComponent<SpriteRenderer>();
		Color c = spr.color;
		c.a = 0.0f;
		spr.color = c;
			}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			StartCoroutine(nameof(FadeIn));
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			StartCoroutine("FadeOut");
		}
	}


	IEnumerator FadeIn()
	{
		for (float f = 0.0f; f <= 1; f += 0.02f)
		{
			Color c = spr.color;
			c.a = f;
			spr.color = c;
			yield return new WaitForSeconds(0.02f);
		}
	}

	IEnumerator FadeOut()
	{
		for (float f = 1f; f >= 0; f -= 0.02f)
		{
			Color c = spr.color;
			c.a = f;
			spr.color = c;
			yield return new WaitForSeconds(0.02f);
		}
	}
}

