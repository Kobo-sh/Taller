using UnityEngine;

public class Sumarvida : MonoBehaviour
{
    [SerializeField] private Gamemanager gm;
    private void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.gameObject.tag == "Player")
        {
            gm.Sumarvida(1);
            Destroy(this.gameObject);

        }

    }



}
