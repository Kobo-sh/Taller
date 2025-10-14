using UnityEngine;
using TMPro;
using UnityEngine.UI;
using JetBrains.Annotations;

public class UImanager : MonoBehaviour
{
 int vida =5;

    //corazon funcionamiento
  
    [SerializeField] private UIitems[] corazones;
    
 

    public void ActivarCorazones(int vida)
    {
        for (int i = 0; i < 5; i++)
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