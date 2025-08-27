using UnityEngine;

public class MuslosTiempo : MonoBehaviour
{
    public float timeToAdd = 5f; // Tiempo a agregar al contador.
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Tiempo timeCounter = Object.FindAnyObjectByType<Tiempo>();
            if (timeCounter != null)
            {
                timeCounter.AddTime(timeToAdd);
            }

            Destroy(gameObject);
        }
    }
}
