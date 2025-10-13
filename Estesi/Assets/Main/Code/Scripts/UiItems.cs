using JetBrains.Annotations;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIitems : MonoBehaviour
{

    //funcionamiento corazones imagenes

    [SerializeField] private Image CorazonImagen;

    [SerializeField] private bool CorazonActivo;

    public void ActivarCorazon()
    {
        CorazonImagen.enabled = true;
        CorazonActivo = true;
    }
    public void DesactivarCorazon()
    {
        CorazonImagen.enabled = false;
        CorazonActivo = false;
    }

    public bool Corazonactivo() => CorazonActivo;

    //llave



    private void Update()
    {
        if (Gamemanager.llave == true)
        {
            Time.timeScale = 0f;
        }
        else
        {

        }
    }

