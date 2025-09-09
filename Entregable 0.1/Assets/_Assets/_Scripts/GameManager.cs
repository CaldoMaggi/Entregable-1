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

    public void EstadoLlave(bool tieneLlave)
    {
        LlaveActiva = tieneLlave;
        ActualizarUI("Llave");

    }


    public void SumarPuntos(int cantidad)
    {
        puntos += cantidad;
        //textoPuntos.text = "Huesos: " + puntos;
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
       // textoVida.text = "Vida: " + vida;
        VidaTotal(vida);
    }

    public void SumarVida(int musloVida)
    {
        vida += musloVida;
       // textoVida.text = "Vida: " + vida;
        VidaTotal(vida);
    }
    private void VidaTotal(int vida)
    {
        if (vida <= 0)
        {
            //SceneManager.LoadScene(0);
        }
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