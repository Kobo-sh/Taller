using UnityEngine;

public class Inventario : MonoBehaviour
{
 public bool tieneLlave { get; private set; } = false;

    public void llave()
    {
        tieneLlave = true;
        Debug.Log("¡Llave recogida!");
    }
}
