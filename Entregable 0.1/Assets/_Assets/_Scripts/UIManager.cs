using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    [SerializeField]
    private TMP_Text textoPuntos;
    [SerializeField]
    private TMP_Text textoVida;
    [SerializeField]
    private TMP_Text textoLlave;


    public void EstadoDeJuego(string estado)
    {
        
        switch (estado)
        {
            case "Ganaste":
                SceneManager.LoadScene(1);
                break;

            case "Perdiste":
                SceneManager.LoadScene(0);
                break;

            case "Pausa":
                Time.timeScale = 0;
                break;

            case "Jugando":
                Time.timeScale = 1;
                break;
            case "Salir":
                Application.Quit();
                break;
        }
    }

    public void ActualizarUI(string texto)
    {
        Debug.Log("estado del juego");
        switch (texto)
        {
            case "Vida":
                Debug.Log("vidas");
                textoVida.text = "Vida: " + gameManager.vida;
                break;

            case "Puntos":
                
                textoPuntos.text = "Huesos: " + gameManager.puntos;
                break;

            case "Llave":
                textoLlave.text = "Llave: Si ";
                break;
        }
    }

}
