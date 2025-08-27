using System.Collections;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Runtime.CompilerServices;


public class Tiempo : MonoBehaviour
{
    public TextMeshProUGUI tiempoText;
    public float tiempoFaltante;
    public void AddTime(float timeToAdd)
    {
        tiempoFaltante += timeToAdd;
        Update();
    }
    private void Update()
    {
        if (tiempoFaltante > 0)
        {
            tiempoFaltante -= Time.deltaTime;
        }
        if (tiempoFaltante < 0)
        {
            tiempoFaltante = 0;
            CambiarEscena();
        }

        int minutes = Mathf.FloorToInt(tiempoFaltante / 60);
        int seconds = Mathf.FloorToInt(tiempoFaltante % 60);

        tiempoText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        void CambiarEscena()
        {
            SceneManager.LoadScene(0);
        }

    }
}