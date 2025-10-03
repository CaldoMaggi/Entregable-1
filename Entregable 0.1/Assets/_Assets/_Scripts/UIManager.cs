using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using UnityEditor;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    [SerializeField]
    private TMP_Text textoPuntos;
    [SerializeField]
    private Image[] spriteCorazon;
    [SerializeField]
    private Image spriteLLave;
    [SerializeField]
    private GameObject Canvas;

    public void ActualizarCorazones(int vida)
    {
        for (int i = 0; i < spriteCorazon.Length; i++)
        {
            // Activa los corazones si el índice es menor a la vida, sino los desactiva
            spriteCorazon[i].enabled = i < vida;
        }
    }
    public void ActualizarLlave(bool tieneLlave)
    {
        if(tieneLlave == true)
        {
            spriteLLave.enabled = true;
        }
    }

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
                Canvas.SetActive(true);
                break;

            case "Jugando":
                Time.timeScale = 1;
                Canvas.SetActive(false);
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
            case "Puntos":
                
                textoPuntos.text = "Huesos: " + gameManager.puntos;
                break;
        }
    }
    public void Jugar()
    {
        SceneManager.LoadScene(0);
    }
    public void Salir()
    {
        Application.Quit();
    }
}
