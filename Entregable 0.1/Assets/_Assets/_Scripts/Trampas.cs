using Unity.VisualScripting;
using UnityEngine;

public class Trampa : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameManager.RestarVida(10);
        }
    }
   
    
}
