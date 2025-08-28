using UnityEngine;
using TMPro;

public class TallerVariables : MonoBehaviour
{
    [SerializeField]
    private string _nombre = "kobo";
    [SerializeField]
    private int _vida = 100;
    [SerializeField]
    private float _tiempo = 60.5f;
    [SerializeField]
    private int _puntos = 100;
    [SerializeField]
    private bool _isAlive = true;

    [SerializeField]
    private TMP_Text _nombreUI;
    [SerializeField]
    private TMP_Text _vidaUI;
    [SerializeField]
    private TMP_Text _tiempoUI;
    [SerializeField]
    private TMP_Text _puntosUI;
    [SerializeField]
    private TMP_Text _isAliveUI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      _nombreUI.text = "Nombre: " + _nombre;
      _vidaUI.text = "Vida: " + _vida;
      _tiempoUI.text = "Tiempo: " + _tiempo;
      _puntosUI.text = "Puntos: " + _puntos;
      _isAliveUI.text = "Esta vivo: " + _isAlive;
            
    }

    // Update is called once per frame
    void Update()
    {
        if (_nombre == "kobo")
        {
            Debug.Log("Hola kobo");

        }
        else
        {
            Debug.Log("Hola se�or");
        }

    }
}

