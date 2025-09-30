using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using TMPro;

public class Gamemanager : MonoBehaviour
{
    //variables

    [SerializeField] public static int puntos = 0;
    [SerializeField] private int vida = 10;
    [SerializeField] private float tiempo = 60f;
    [SerializeField] private int tiempoE;
    [SerializeField] public bool llave;
    [SerializeField] private GameObject menu;


    //TMP
    [SerializeField] private TMP_Text _puntos;
    [SerializeField] private TMP_Text _tiempoE;
    [SerializeField] private TMP_Text _vida;
    [SerializeField] private TMP_Text _llave;
    [SerializeField] private TMP_Text _jugador;


    // Estado del juego

    public void EstadoDelJugador()
    {
        if (vida == 1)
        {
            _jugador.text = "Busca curacion";
        }
        else if (vida == 5)
        {
            _jugador.text = "Cuidado";
        }
        else if (vida >= 10)
        {
            _jugador.text = "Estás bien";
        }
        if (vida <= 0)
        {
            _jugador.text = "murio";
        }

    }

    public void EstadoDelJuego(string estado)
    {
        switch (estado)
        {
            case "Play":
                Time.timeScale = 1;
                break;

            case "Pause":
                Time.timeScale = 0;
                break;

            case "Ganaste":
                SceneManager.LoadScene("Victoria");
                break;

            case "Perdiste":
                SceneManager.LoadScene("Derrotra");
                break;
            case "salir":
                Application.Quit();
                //Debug.Log("funciona"); compruebo la funcionalidad
                break;
        }
    }



    // Suma de puntos y actualizacion de UI
    //public bool llave = true;
    public void salida()
    {
        SceneManager.LoadScene("Victoria");
    }

    public void estado()
    {
        llave = true;

    }

    public void Sumarpunto(int cantidad)
    {
        puntos += cantidad;
    }
    public void RestarVida(int cantidad)
    {
        vida -= cantidad;

        if (vida == 0)
        {
            SceneManager.LoadScene("Derrota");
        }

    }

    public void Sumarvida(int cantidad)
    {
        vida += cantidad;


    }

    public void SumarTiempo(int cantidad)
    {
        tiempo += cantidad;

    }

    private void Update()
    {
        if (tiempo > 0)
        {
            tiempo -= Time.deltaTime;
            tiempoE = (int)tiempo;
        }
        if (tiempo <= 0)
        {

            SceneManager.LoadScene("Derrota");

        }

        //if SceneManager.LoadScene("Taller")




        {
            _puntos.text = "puntos: " + puntos;  //se actualizara cuando haga contacto con el item

            _tiempoE.text = "Tiempo: " + tiempoE;

            _vida.text = "vida: " + vida;

            _llave.text = "Llave: " + llave;

            EstadoDelJugador();

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                EstadoDelJuego("Pause");       // Pausa el juego
                menu.SetActive(true);    // Muestra el panel de pausa

            }
        }
    }
}
    


        









