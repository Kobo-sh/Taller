using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    // Variables lógicas del juego
    [SerializeField] public int puntos = 0;
    [SerializeField] private int vida = 5;
    [SerializeField] private float tiempo = 60f;
    [SerializeField] private int tiempoE;
    [SerializeField] public bool llave;

    // Referencia al UIManager para actualizar visuales
    [SerializeField] private UIManager uiManager;

    private void Update()
    {
        // Detectar la escena actual
        string escenaActual = SceneManager.GetActiveScene().name;

        if (escenaActual == "Taller Andres")
        {
            if (tiempo > 0)
            {
                tiempo -= Time.deltaTime;
                tiempoE = (int)tiempo;
            }
            else if (tiempo <= 0)
            {
                EstadoDelJuego("Perdiste");
            }

            
            uiManager.ActualizarInterfaz(puntos, tiempoE, vida, llave);

            uiManager.EstadoDelJugador(vida);

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                EstadoDelJuego("Pause");
                uiManager.MostrarMenu(true);
            }
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
                SceneManager.LoadScene("Derrota");
                break;

            case "Reintentar":
                SceneManager.LoadScene("Taller Andres");
                break;

            case "salir":
                Application.Quit();
                Debug.Log("funciona!");
                break;
        }
    }

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

        if (vida <= 0)
        {
            vida = 0;
            EstadoDelJuego("Perdiste");
        }

        
        uiManager.ActualizarVidaVisual(vida);
    }

    public void Sumarvida(int cantidad)
    {
        vida += cantidad;
        if (vida > 5) vida = 5;

        
        uiManager.ActualizarVidaVisual(vida);
    }

    public void SumarTiempo(int cantidad)
    {
        tiempo += cantidad;
    }
}











