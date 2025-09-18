using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text tituloText;
    [SerializeField]
    private TMP_Text alertasText;

    [SerializeField]
    private TMP_InputField respuestaInput;

    [SerializeField]
    private Button enviarButton;

    private void start()
    {
        //tituloText.text = "Introduce tu edad..." forma de hacerlo desde el codigo
        alertasText.text = "";
        enviarButton.onClick.AddListener(FuncionDelBoton);

        //en el primer frame del juego el boton va a estar escuchando siempre al evento OnClick

    }

    public void FuncionDelBoton()
    {
        int edad = int.Parse(respuestaInput.textComponent.text);

    }


}
   