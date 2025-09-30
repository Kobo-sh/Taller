using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class UImanager : MonoBehaviour
{
    [SerializeField] private TMP_Text titulotext;
    [SerializeField] private TMP_Text advertenciatext;

    [SerializeField] private TMP_InputField respuestaInput;

    [SerializeField] Button enviarButton;

    //variable

    [SerializeField] int edad;

    private void Start()
    {
        titulotext.text = "Hola, introduce tu edad";

        advertenciatext.text  = "";

        enviarButton.onClick.AddListener(FuncionDelBoton);  // se utiliza para remplazar la configuracion manual del boton lo unico necesario es la funcion que ejecute el boton 
    }

    public void FuncionDelBoton()
    {

        edad = int.Parse(respuestaInput.textComponent.text);

    }
}
