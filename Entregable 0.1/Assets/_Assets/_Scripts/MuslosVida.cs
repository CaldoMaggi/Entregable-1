using UnityEngine;

public class MuslosVida : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (gameManager.vida < 5)
            {
                gameManager.SumarVida(1);
            }
            Destroy(this.gameObject);
        }
    }
}
