using UnityEngine;
using UnityEngine.SceneManagement;

public class Chozaa : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    private bool ChozaActive = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController player = other.GetComponent<PlayerController>();

            if (player != null && player.tieneLlave) // Si el jugador tiene la llave
            {
                gameManager.EstadoChoza(true);
                Debug.Log("¡Ganaste!");
            }
            else
            {
                gameManager.EstadoChoza(false);
                Debug.Log("La choza está cerrada. Necesitas la llave.");
            }
        }
    }
}
