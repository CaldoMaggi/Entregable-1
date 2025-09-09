using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text Textintro;
    [SerializeField]
    private TMP_InputField Inputfield;
    private int edad;


    public void Start ()
    {
        
    }

    public void CalcularGrupo()
    {
        edad = int.Parse(Inputfield.text);

        switch (edad)
        {
            case 18:

                Debug.Log("Tienes 18 años");

                break;

            case 25:
                print("Tienes 25 años");

                break;

            case 40:
                print("Tienes 40 años");

                break;

            default:
                print("Tienes otra edad");

                break;
        }

        /*
        if (edad <= 12)
        {
            Debug.Log("Eres un niño");

        }
        else if (edad >= 13 && edad <= 18) 
        {
            Debug.Log("Eres un Adolecente");
        }
        else if (edad >= 19 && edad <= 25)
        {
            Debug.Log("Eres un Adulto Joven");
        }
        else if (edad >= 26 && edad <= 60)
        {
            Debug.Log("Eres un Adulto");
        }
        else if (edad >= 60 && edad < 100)
        {
            Debug.Log("Eres un Adulto Mayor");
        }
        else if (edad >= 100)
        {
            Debug.Log("Eres un ENTE");
        }
        */
       
    }

}
