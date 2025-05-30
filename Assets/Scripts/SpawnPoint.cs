using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public string idEntrada; 
    private void Start()
    {
        if (GameManager.DatosJuego.idProximoSpawn == idEntrada)
        {
            GameObject jugador = GameObject.FindGameObjectWithTag("Player");
            if (jugador != null)
            {
                jugador.transform.position = transform.position;
            }
        }
    }
}
