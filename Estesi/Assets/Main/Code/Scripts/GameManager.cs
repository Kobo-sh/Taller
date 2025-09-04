using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using TMPro;

public class Gamemanager : MonoBehaviour
{
    //variables

    [SerializeField] public static int puntos = 9;
    [SerializeField] private int vida = 10;
    [SerializeField] private float tiempo = 60f;
    [SerializeField] private int tiempoE;
    [SerializeField] public bool llave;
   

    //TMP
    [SerializeField] private TMP_Text _puntos;
    [SerializeField] private TMP_Text _tiempoE;
    [SerializeField] private TMP_Text _vida;
    [SerializeField] private TMP_Text _llave;
    //

    // Suma de puntos y actualizacion de UI
//public bool llave = true;
public void salida()
{
    SceneManager.LoadScene("Victoria");
}


    public bool Llave = false;
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
            SceneManager.LoadScene("Taller");
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

            SceneManager.LoadScene("Taller");

        }

        //if SceneManager.LoadScene("Taller")

    


        {
            _puntos.text = "puntos: " + puntos;  //se actualizara cuando haga contacto con el item

            _tiempoE.text = "Tiempo: " + tiempoE;

            _vida.text = "vida: " + vida;

            _llave.text = "Llave: " + llave; 

        }
    }
}
    


        









