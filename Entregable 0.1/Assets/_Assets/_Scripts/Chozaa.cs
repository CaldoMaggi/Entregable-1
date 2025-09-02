using UnityEngine;
using UnityEngine.SceneManagement;

public class Chozaa : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController player = other.GetComponent<PlayerController>();

            if (player != null && player.tieneLlave) // Si el jugador tiene la llave
            {
                Debug.Log("¡Ganaste!");
                SceneManager.LoadScene(1); // Cambia al índice 1 en Build Settings
            }
            else
            {
                Debug.Log("La choza está cerrada. Necesitas la llave.");
            }
        }
    }
}
