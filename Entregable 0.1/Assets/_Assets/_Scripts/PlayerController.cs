using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb2d;
    void Update()
    {
        bool flechaUp = Input.GetKeyDown(KeyCode.UpArrow);
        bool flechaLeft = Input.GetKeyDown(KeyCode.LeftArrow);
        bool flechaRight = Input.GetKeyDown(KeyCode.RightArrow);
        rb2d = GetComponent<Rigidbody2D>();

        if (flechaUp)
        {
            Debug.Log("UpArrow key was pressed.");
            rb2d.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
        }

        if (flechaLeft)
        {
            Debug.Log("flechaLeft key was pressed.");
            rb2d.AddForce(Vector2.left * 2, ForceMode2D.Impulse);
        }

        if (flechaRight)
        {
            Debug.Log("flechaRight key was pressed.");
            rb2d.AddForce(Vector2.right * 2, ForceMode2D.Impulse);
        }
    }
}
