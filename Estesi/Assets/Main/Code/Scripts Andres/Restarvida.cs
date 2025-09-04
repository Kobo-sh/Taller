using UnityEngine;
using Unity.VisualScripting;

public class Vida : MonoBehaviour
{


           [SerializeField] private Gamemanager gameManager;
    private void OnCollisionEnter2D(Collision2D collision)

    {
        if (collision.gameObject.tag == "Player")
        {
            gameManager.RestarVida(1);
        }
    }

 
    }

