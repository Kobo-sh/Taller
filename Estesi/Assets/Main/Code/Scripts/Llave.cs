using UnityEngine;

public class Llave : MonoBehaviour
{

    [SerializeField]
    private Gamemanager gmr;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player");
        {
            gmr.estado();
        
            Debug.Log("¡LLAVE!");
            
        
              Destroy(this.gameObject);
        }
    }
}
