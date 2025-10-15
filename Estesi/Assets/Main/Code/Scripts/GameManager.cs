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
    [SerializeField] private UImanager uiManager;
    [SerializeField] GameObject menuPausa;


    //TMP
    [SerializeField] private TMP_Text _puntos;
    [SerializeField] private TMP_Text _tiempoE;
    [SerializeField] private TMP_Text _vida;
    [SerializeField] private TMP_Text _llave;
    

    // Suma de puntos y actualizacion de UI
    //public bool llave = true;

public void salida()
{
    SceneManager.LoadScene("Victoria");
}

    public void estado()
    {
        llave = true;
        uiManager.ActivarIconoLlave(llave);

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
            SceneManager.LoadScene("Taller");
        }

        uiManager.ActivarCorazones(vida);

        if (vida > 5)
        {
            vida = 5;
        }

    }

        public void Sumarvida(int cantidad)
    {
        vida += cantidad;
        uiManager.ActivarCorazones(vida);
        if (vida > 5)
        {
            vida = 5;
        }

    }
    
            public void SumarTiempo(int cantidad)
    {
        tiempo += cantidad;
        
    }

    private void Update()
    {
        {

            //pausa

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (menuPausa.activeSelf)
                {
                    EstadoDelJuego("Play");
                    menuPausa.SetActive(false);
                }
                else
                {
                    EstadoDelJuego("Pause");
                    menuPausa.SetActive(true);
                }

            }
        } 


        if (tiempo > 0)
        {
            tiempo -= Time.deltaTime;
            tiempoE = (int)tiempo;
        }
        if (tiempo <= 0)
        {

            SceneManager.LoadScene("Taller");

        }

        
        {
            _puntos.text = "puntos: " + puntos;  //se actualizara cuando haga contacto con el item

            _tiempoE.text = "Tiempo: " + tiempoE;

            _vida.text = "vida: " + vida;

            _llave.text = "Llave: " + llave; 

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
        case "Quit":
            Application.Quit();
            break;
        }
    }    




    
}
    


        









