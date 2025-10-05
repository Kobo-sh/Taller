using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [Header("Referencias UI")]
    [SerializeField] private TMP_Text _puntos;
    [SerializeField] private TMP_Text _tiempoE;
    [SerializeField] private TMP_Text _vida;
    [SerializeField] private TMP_Text _llave;
    [SerializeField] private TMP_Text _jugador;
    [SerializeField] private GameObject menu;

    // Actualiza los textos visuales sin modificar lógica
    public void ActualizarInterfaz(int puntos, int tiempoE, int vida, bool llave)
    {
        _puntos.text = "puntos: " + puntos;

        _tiempoE.text = "Tiempo: " + tiempoE;

       _vida.text = "vida: " + vida;

        _llave.text = "Llave: " + llave;
    }

    // Muestra el estado del jugador según la vida
    public void EstadoDelJugador(int vida)
    {

        if (vida == 3)
        {
            _jugador.text = "Busca curacion";
        }
        else if (vida == 5)
        {
            _jugador.text = "Estás bien";
        }
        else if (vida <= 0)
        {
            _jugador.text = "Murió";
        }
    }

    // Control del menú de pausa
    public void MostrarMenu(bool activo)
    {
        if (menu != null)
            menu.SetActive(activo);
    }
}
