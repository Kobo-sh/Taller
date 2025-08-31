using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] private float velocidad = 5f;
    [SerializeField] private float salto = 8f;
    private Rigidbody2D rb;
    private bool suelo;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Movimiento horizontal
        float Movimiento = Input.GetAxis("Horizontal"); // A/D o flechas
        rb.linearVelocity = new Vector2(Movimiento * velocidad, rb.linearVelocity.y);

        // Salto


        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector2.up * salto, ForceMode2D.Impulse);
        }
    }
}
    

