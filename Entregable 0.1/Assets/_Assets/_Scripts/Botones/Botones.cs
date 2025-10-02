using UnityEngine;
using UnityEngine.SceneManagement;
public class Botones : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene(0);
    }
    public void Salir()
    {
        Application.Quit();
    }
}

