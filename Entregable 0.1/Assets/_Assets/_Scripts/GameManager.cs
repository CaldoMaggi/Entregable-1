using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using JetBrains.Annotations;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject Obstaculo;
    [SerializeField]
    private GameObject Canvas;
    [SerializeField]
    private UIManager _UIManager;
    [SerializeField]
    private bool _estaPausado = false;
    [SerializeField]
    private bool LlaveActiva = false;
    [SerializeField]
    private bool ChozaActiva = false;
    public int puntos;
    public int vida;

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
        if (vida == 0)
        {
            _UIManager.ActualizarUI("Vida");
            _UIManager.EstadoDeJuego("Perdiste");
            _UIManager.ActualizarCorazones(vida);
        }
        _UIManager.ActualizarUI("Vida");
        _UIManager.ActualizarCorazones(vida);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Canvas.activeSelf) //desactivar
            {
                _UIManager.EstadoDeJuego("Jugando");
            }
            else // activar
            {
                _UIManager.EstadoDeJuego("Pausa");
            }
        }
    }
    public void EstadoChoza(bool ChozaActive)
    {
        ChozaActiva = ChozaActive;
        if(ChozaActiva == false)
        {
        } else if (ChozaActiva == true)
        {
            _UIManager.EstadoDeJuego("Ganaste");
        }

    }
}