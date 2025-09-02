using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

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

    public void EstadoLlave(bool tieneLlave)
    {
        if (tieneLlave == false)
        {
            textoLlave.text = "Llave: No ";
        }
        
        if(tieneLlave == true)
        {
            textoLlave.text = "Llave: Si ";
        }
    }


    public void SumarPuntos(int cantidad)
    {
        puntos += cantidad;
        textoPuntos.text = "Huesos: " + puntos;

        if (puntos >= 10)
        {
            Destroy(Obstaculo);
            Debug.Log("Ve por la llave");
        }
    }

    public void RestarVida(int salud)
    {
        vida -= salud;
        textoVida.text = "Vida: " + vida;
        VidaTotal(vida);
    }

    public void SumarVida(int musloVida)
    {
        vida += musloVida;
        textoVida.text = "Vida: " + vida;
        VidaTotal(vida);
    }
    private void VidaTotal(int vida)
    {
        if (vida <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}