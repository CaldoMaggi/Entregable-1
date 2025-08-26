using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D _rb2d;
    public float fuerzaSalto;
    public Vector2 direccionSalto;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _rb2d.AddForce(direccionSalto * fuerzaSalto);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow)) 
        {
            _rb2d.AddForce(direccionSalto * -fuerzaSalto);
        }
        else if(Input.GetKeyUp(KeyCode.RightArrow))
        {
            _rb2d.AddForce(direccionSalto * fuerzaSalto);
        }
    
    }
}
