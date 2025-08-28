using UnityEngine;

public class MonedaControl : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player");
        {
            gameManager.SumarPuntos(1);
            
            Debug.Log("¡MONEDA OBTENIDA!");
            
            Destroy(this.gameObject);
        }
    }
}
