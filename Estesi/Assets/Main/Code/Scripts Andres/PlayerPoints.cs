using UnityEngine;

// Clase pública que almacena los puntos del jugador
public class PlayerPoints : MonoBehaviour
{
    public int puntosTotales = 0; // Total de puntos

    // Método opcional para sumar puntos de manera segura
    public void AgregarPuntos(int cantidad)
    {
        puntosTotales += cantidad;
        Debug.Log("Puntos totales: " + puntosTotales);
    }
}