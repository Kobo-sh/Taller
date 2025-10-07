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

    
    [SerializeField] private GameObject[] imagenesVida;

   
    public void ActualizarInterfaz(int puntos, int tiempoE, int vida, bool llave)
    {
        _puntos.text = "Puntos: " + puntos;
        _tiempoE.text = "Tiempo: " + tiempoE;
        _vida.text = "Vida: " + vida;
        _llave.text = "Llave: " + llave;
    }

    
    public void EstadoDelJugador(int vida)
    {
        if (vida == 3)
        {
            _jugador.text = "Busca curación";
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

    
    public void MostrarMenu(bool activo)
    {
        if (menu != null)
            menu.SetActive(activo);
    }

   
    public void ActualizarVidaVisual(int cantidadVida)
    {
        if (imagenesVida == null) return;

        for (int i = 0; i < imagenesVida.Length; i++)
        {
            imagenesVida[i].SetActive(i < cantidadVida);
        }
    }
}
