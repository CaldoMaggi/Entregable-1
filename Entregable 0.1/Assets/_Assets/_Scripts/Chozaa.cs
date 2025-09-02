using UnityEngine;
using UnityEngine.SceneManagement;

public class Chozaa : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController p = other.GetComponent<PlayerController>();

            if (p != null && p.tieneLlave) // Si el jugador tiene la llave
            {
                Debug.Log("¡Ganaste! Cargando siguiente escena...");
                SceneManager.LoadScene(1); // Cambia al índice 1 en Build Settings
            }
            else
            {
                Debug.Log("La choza está cerrada. Necesitas la llave.");
            }
        }
    }
}
