using UnityEngine;


public class PELIGRO : MonoBehaviour 
{
    [SerializeField]
    private GameManager gamemanager;
    private void OnCollisionEnter2D(Collision2D collision)
    {
    
     if (collision.gameObject.tag == "Player");
     {
        Time.timeScale = 1f;

        gamemanager.RestarVida(1);
        
     }
    }
    
}
