using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField] private Gamemanager game;

    void Update()
    {
        if (game.puntos >= 10)
        {
            Destroy(this.gameObject);
        }
    }
}