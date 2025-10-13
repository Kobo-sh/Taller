using UnityEngine;
using TMPro;
using UnityEngine.UI;
using JetBrains.Annotations;

public class UImanager : MonoBehaviour
{


    //corazon funcionamiento
  
    [SerializeField] private UIitems[] corazones;
    [SerializeField] private Gamemanager VidaJugador;
    private void Start()
    {
        VidaJugador = FindFirstObjectByType<Gamemanager>();

    }

    private void ActivarCorazones(int vida)
    {
        for (int i = 0; i < corazones.Length; i++)
        {
            if (i < vida)
            {
                corazones[i].ActivarCorazon();
            }
            else
            {
                corazones[i].DesactivarCorazon();
            }
        
        

        }
    }
}