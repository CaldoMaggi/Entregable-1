using UnityEngine;

public class Moneda : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            gameManager.SumarPuntos(1);
            Destroy(this.gameObject);
        }
    }
}
