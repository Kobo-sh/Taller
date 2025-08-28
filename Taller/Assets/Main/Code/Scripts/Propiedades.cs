using UnityEngine;

public class Controles : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb2d;

    [SerializeField]
    private float fuerza =100f;
    [SerializeField]
    private float x =1f;
    [SerializeField]
    private float y =1f;
    
    

     void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.AddForce(new Vector2( x,y ) * fuerza);
            
        }
        else
        
        {
            
        }
    }
}
