using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    public string idEntrada;            // (No es necesario en este script, a menos que lo uses luego)
    public string escenaDestino;        
    public string idEntradaDestino;     // ID del spawn en la nueva escena

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.DatosJuego.idProximoSpawn = idEntradaDestino;
            SceneManager.LoadScene(escenaDestino);
        }
    }
}
