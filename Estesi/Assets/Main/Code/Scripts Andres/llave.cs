using UnityEngine;

public class llave : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Verifica que sea el jugador
        {
            Inventario inventario = other.GetComponent<Inventario>();
            if (inventario != null)
            {
                inventario.llave();
            }

            
            Destroy(gameObject);
        }
    }
}