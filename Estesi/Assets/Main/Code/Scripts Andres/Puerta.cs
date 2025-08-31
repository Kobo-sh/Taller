using UnityEngine;

public class Puerta : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;

        Inventario inventario = other.GetComponent<Inventario>();
        if (inventario != null && inventario.tieneLlave)
        {
            gamemanager1.Instance.Victoria(); // Mostrar victoria
        }
    }
}
