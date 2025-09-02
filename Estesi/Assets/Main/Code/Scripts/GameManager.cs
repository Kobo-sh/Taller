using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   [SerializeField]
   private int _puntos;
   [SerializeField]
   private int _vida = 10;
   [SerializeField]
   private float _tiempo = 60;

   [SerializeField]
   private int _tiempoEntero;

   private void Update()
   {
    if (_tiempo > 0)
    {
        _tiempo -= Time.deltaTime;
        _tiempoEntero = (int)_tiempo;

        Debug.Log("Tiempo restante: " + Mathf.CeilToInt(_tiempo)) ;
    }
    if (_tiempo <=0)
    {

        SceneManager.LoadScene("Taller");

    }
   }
   
   public void SumarPuntos(int cantidad)
   {
    _puntos +=cantidad;

   }


    public void RestarVida(int cantidad)
    {
        if (_vida <= 0)
        {

        SceneManager.LoadScene("propiedades");
        }

    
    else
    {
        _vida -=cantidad;
    }

   }
    
}