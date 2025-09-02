using UnityEngine;

public class PuntoHueso : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    public int cantidad;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            gameManager.SumarPuntos(cantidad);
            Destroy(this.gameObject);
        }
    }
}
