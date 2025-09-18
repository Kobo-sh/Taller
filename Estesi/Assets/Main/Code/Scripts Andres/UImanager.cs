using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class UImanager : MonoBehaviour
{
    [SerializeField] private TMP_Text titulotext;
    [SerializeField] private TMP_Text advertenciatext;

    [SerializeField] private TMP_InputField respuestaInput;

    [SerializeField] Button enviarButton;

    private void Start()
    {
        enviarButton.onClick.AddListener(FuncionDelBoton);  // se utiliza para remplazar la configuracion manual del boton lo unico necesario es la funcion que ejecute el boton 
    }

    public void FuncionDelBoton()
    {

    }
}
