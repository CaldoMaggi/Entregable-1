using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] gameObjectcorazon;
    [SerializeField]
    private Image[] ImageCorazon;
    [SerializeField]
    private GameManager gameManager;

        public void ActualizarCorazones()
    {
        for (int i = 0; i < 4; i++)
        {
            ImageCorazon[i].enabled = true;

        }
        //  gameObjectcorazon[0].SetActive(false);
       
    }
    

}
