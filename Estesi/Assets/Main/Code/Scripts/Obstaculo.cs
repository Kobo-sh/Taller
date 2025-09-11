using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    void Update()
    {
        if( Gamemanager.puntos >= 10)
        {  Destroy(this.gameObject);
}
    
    
    }
}