using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Llave : MonoBehaviour
{
    public GameObject player;
    public GameObject door;
    public bool isPickedUp;
    private Vector2 vel;
    public float smoothTime;

    private void Start()
    {
        isPickedUp = false;
    }
    private void Update()
    {
        if (isPickedUp)
        {
            Vector3 offset= new Vector3(0, 1.7f, 0);
            transform.position = Vector2.SmoothDamp(transform.position,player.transform.position + offset, ref vel, smoothTime);
        }
    }
    void CambiarEscena()
    {
        SceneManager.LoadScene(1);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player") && !isPickedUp)
        {
            isPickedUp = true;
            door.GetComponent<Choza>().keyPickUp = true;
        }
    }
}
