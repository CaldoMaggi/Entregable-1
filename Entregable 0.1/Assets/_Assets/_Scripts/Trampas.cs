using Unity.VisualScripting;
using UnityEngine;

public class Trampa : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameManager.RestarVida(10);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            Debug.Log("se pausó el juego");
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            Time.timeScale = 1;
            Debug.Log("se reanudó el juego");
        }
    }
}
