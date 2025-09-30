using UnityEngine;

public class MuslosVida : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            gameManager.SumarVida(5);
            Destroy(this.gameObject);
        }
    }
}
