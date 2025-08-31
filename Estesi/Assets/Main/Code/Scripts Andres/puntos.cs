using UnityEngine;

public class Hueso : MonoBehaviour
{
    public int valor = 10; // Cantidad de puntos que da

    // Al tocar el jugador
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;

        // Obtener el script PlayerPoints del jugador
        PlayerPoints player = other.GetComponent<PlayerPoints>();
        if (player != null)
        {
            player.puntosTotales += valor; // Sumar puntos
            Destroy(this.gameObject);           // Destruye el hueso
        }
    }
}