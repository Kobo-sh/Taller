using UnityEngine;

public class SumarTiempo : MonoBehaviour
{
    [SerializeField] private Gamemanager gmanager;
    private void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.gameObject.tag == "Player")
        {
            gmanager.SumarTiempo(30);
            Destroy(this.gameObject);

        }

    }



}