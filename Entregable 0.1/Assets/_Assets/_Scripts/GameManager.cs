using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int vida;
    public int puntos = 0;
    [SerializeField]
    private TMP_Text textoPuntos;
    [SerializeField]
    private TMP_Text textoVida;
    [SerializeField]
    private TMP_Text textoContador;

    public void SumarPuntos(int cantidad)
    {
        puntos += cantidad;
        textoPuntos.text = "Puntos: " + puntos;
    }

    public void RestarVida(int salud)
    {
        vida -= salud;
        textoVida.text = "Vida: " + vida;
    }
}