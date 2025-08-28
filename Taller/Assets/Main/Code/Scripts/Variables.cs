using UnityEngine;
using TMPro;

public class Variables : MonoBehaviour
{
    [Header("Variables c#")]
    [SerializeField]
    private int vida= 1;
    [SerializeField]
    private int puntaje = 200;
    [SerializeField]
    private int nivel = 29;

    public string nombre = "kobo";
    [SerializeField]
    private float tiempo = 1.60f;
    [SerializeField]
    private bool isAlive = true;

    [Header("Variables Unity")]
    [SerializeField]
    private TMP_Text mensaje;
 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mensaje.text = "Hola" +  nombre + ", C�mo est�s?";
    }

    // Update is called once per frame
    void Update()
    {
        print("Hola mundo!!");
    }
}
