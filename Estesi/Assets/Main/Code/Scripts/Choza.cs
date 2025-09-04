using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
   [SerializeField] public Gamemanager Gamemanager;
    private void OnCollisionEnter2D(Collision2D collision)
   {
    if (collision.gameObject.CompareTag("Player"))
    {
        if (Gamemanager.llave == true)
        {
            SceneManager.LoadScene("Victoria");
            Time.timeScale = 0f;
        }
    }
    else
    {
        
    }
  }
}

