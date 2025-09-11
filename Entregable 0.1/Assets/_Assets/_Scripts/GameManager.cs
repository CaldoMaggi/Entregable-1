using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using JetBrains.Annotations;

public class GameManager : MonoBehaviour
{
    public int vida;
    public int puntos = 0;
    public GameObject Obstaculo;

    [SerializeField]
    private TMP_Text textoPuntos;
    [SerializeField]
    private TMP_Text textoVida;
    [SerializeField]
    private TMP_Text textoContador;
    [SerializeField]
    private TMP_Text textoLlave;

    public bool LlaveActiva = false;
    public bool ChozaActiva = false;

    public void EstadoLlave(bool tieneLlave)
    {
        LlaveActiva = tieneLlave;
        ActualizarUI("Llave");

    }


    public void SumarPuntos(int cantidad)
    {
        puntos += cantidad;
        ActualizarUI("Puntos");

        if (puntos >= 10)
        {
            Destroy(Obstaculo);
            Debug.Log("Ve por la llave");
        }
    }

    public void RestarVida(int salud)
    {
        vida -= salud;
        VidaTotal(vida);
        ActualizarUI("Vida");
    }

    public void SumarVida(int musloVida)
    {
        vida += musloVida;
        VidaTotal(vida);
        ActualizarUI("Vida");
    }
    private void VidaTotal(int vida)
    {
        ActualizarUI("Vida");
    }
    public void Pausa()
    {
        Input.GetKeyDown(KeyCode.Escape);
          Debug.Log("se pausó el juego");
          EstadoDeJuego("Pausa");
    }
    public void Jugando()
    {
        Input.GetKeyDown(KeyCode.M);
            Debug.Log("se reanudó el juego");
            EstadoDeJuego("Jugando");
    }

    public void EstadoChoza(bool ChozaActive)
    {
        ChozaActiva = ChozaActive;
        EstadoDeJuego("Ganaste");
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
        switch(texto) 
        {
            case "Vida":
                textoVida.text = "Vida: " + vida;
                break;

            case "Tiempo":
                
                break;
            case "Puntos":
                textoPuntos.text = "Huesos: " + puntos;
                break;

            case "Llave":
                textoLlave.text = "Llave: Si ";
                break;
        }
    }
}