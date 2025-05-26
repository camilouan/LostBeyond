using UnityEngine;

public class Hud : MonoBehaviour
{
	public GameObject[] vidas;
	public void DesactivarVida(int indice)
	{
		vidas[indice].SetActive(false);
	}

	public void ActivarVidas(int indice)
	{
		vidas[indice].SetActive(true);
	}

}

