using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using JetBrains.Annotations;

public class GameManager : MonoBehaviour
{
    public GameObject Obstaculo;
    public UIManager _UIManager;
    public bool LlaveActiva = false;
    public bool ChozaActiva = false;
    public int puntos;
    public int vida;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("se pausó el juego");
            _UIManager.EstadoDeJuego("Pausa");
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log("se reanudó el juego");
            _UIManager.EstadoDeJuego("Jugando");

        }
    }
    public void EstadoLlave(bool tieneLlave)
    {
        LlaveActiva = tieneLlave;
        _UIManager.ActualizarLlave(tieneLlave);
    }

    public void SumarPuntos(int cantidad)
    {
        puntos += cantidad;
        _UIManager.ActualizarUI("Puntos");

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
        _UIManager.ActualizarUI("Vida");
        _UIManager.ActualizarCorazones(vida);
    }

    public void SumarVida(int musloVida)
    {
        vida += musloVida;
        VidaTotal(vida);
        _UIManager.ActualizarUI("Vida");
        _UIManager.ActualizarCorazones(vida);
    }
    private void VidaTotal(int vida)
    {
        Debug.Log("vida total");
        if (vida == 0)
        {
            _UIManager.ActualizarUI("Vida");
            _UIManager.EstadoDeJuego("Perdiste");
            _UIManager.ActualizarCorazones(vida);
        }
        _UIManager.ActualizarUI("Vida");
        _UIManager.ActualizarCorazones(vida);
    }
    public void Pausa()
    {
        Input.GetKeyDown(KeyCode.Escape);
          Debug.Log("se pausó el juego");
        _UIManager.EstadoDeJuego("Pausa");
    }
    public void Jugando()
    {
        Input.GetKeyDown(KeyCode.M);
        Debug.Log("se reanudó el juego");
        _UIManager.EstadoDeJuego("Jugando");
    }

    public void EstadoChoza(bool ChozaActive)
    {
        ChozaActiva = ChozaActive;
        if(ChozaActiva == false)
        {
            Debug.Log("falta la llave");
        } else if (ChozaActiva == true)
        {
            _UIManager.EstadoDeJuego("Ganaste");
        }

    }
}