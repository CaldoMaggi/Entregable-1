using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Choza : MonoBehaviour
{
    public bool locked;
    public bool keyPickUp;
    public GameObject player;
    private void Start()
    {
        locked = true;
    }
    private void Update()
    {
        float distance = Vector2.Distance(player.transform.position, transform.position);
        if(!locked && distance < 0.5f)
        {
            SceneManager.LoadScene(1);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Key") && keyPickUp)
        {
            locked = false;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Key") && keyPickUp)
        {
            locked = true;
        }
    }
}
